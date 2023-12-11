using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Scheduler.Data
{
    /// <summary>
    /// 파일 하나 단위와 같은 데이터 북
    /// </summary>
    public class DataBook
    {
        /// <summary>
        /// 할 일 목록
        /// </summary>
        public List<Todo> Todos { get; private set; } = new List<Todo>();
        /// <summary>
        /// 메모 목록 - 미사용
        /// </summary>
        public List<string> Memos { get; private set; } = new List<string>();
        /// <summary>
        /// 해시된 비밀번호
        /// </summary>
        public byte[] Pass { get; private set; } = new byte[0];
        /// <summary>
        /// 비밀번호를 사용할 지 여부를 결정
        /// </summary>
        public bool UsedPass { get; set; } = false;

        /// <summary>
        /// 비밀번호를 입력받아 해시하여 저장
        /// </summary>
        /// <param name="text"> 평문 비밀번호 </param>
        public void SetPass(string text)
        {
            Pass = SHA256.HashData(Encoding.Unicode.GetBytes(text));
        }

        /// <summary>
        /// 데이터를 읽어옴
        /// </summary>
        /// <param name="path"> 데이터를 읽어올 경로 </param>
        /// <param name="usedAES"> AES로 암호화 되었는 지 여부 </param>
        /// <returns> 데이터를 불러오는데 성공하였는 지 여부 </returns>
        public bool Load(string path, bool usedAES)
        {
            UsedPass = usedAES;

            string[] texts;

            if (usedAES == false)
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    texts = reader.ReadToEnd().Split("\r\n");
                }
            }
            else
            {
                byte[] enc;

                using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
                {
                    enc = reader.ReadBytes((int)new FileInfo(path).Length);
                }

                Aes aes = Aes.Create();
                aes.Key = Pass;
                aes.BlockSize = 128;

                try
                {
                    byte[] dec = aes.DecryptCbc(enc, Pass[0..16]);
                    texts = Encoding.Unicode.GetString(dec).Split("\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid password!");
                    Debug.WriteLine(ex);

                    return false;
                }
            }

            Todos = JsonSerializer.Deserialize<List<Todo>>(texts[0]) ?? new List<Todo>();
            Memos = JsonSerializer.Deserialize<List<string>>(texts[1]) ?? new List<string>();
            Pass = JsonSerializer.Deserialize<byte[]>(texts[2]) ?? new byte[0];

            return true;
        }

        /// <summary>
        /// 데이터를 저장함
        /// </summary>
        /// <param name="path"> 데이터를 저장할 경로 </param>
        /// <param name="usedAES"> AES로 암호화 할 지 여부 </param>
        public void Save(string path, bool usedAES)
        {
            if (File.Exists(path) == false)
            {
                File.Create(path).Close();
            }

            UsedPass = usedAES;

            string texts =
                JsonSerializer.Serialize(Todos) + "\r\n" +
                JsonSerializer.Serialize(Memos) + "\r\n" +
                JsonSerializer.Serialize(Pass);

            if (usedAES == false)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(texts);
                }
            }
            else
            {
                Aes aes = Aes.Create();
                aes.Key = Pass;
                aes.BlockSize = 128;
                byte[] enc = aes.EncryptCbc(Encoding.Unicode.GetBytes(texts), Pass[0..16]);

                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(path)))
                {
                    writer.Write(enc);
                }
            }
        }
    }
}
