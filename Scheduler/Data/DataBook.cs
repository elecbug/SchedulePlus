using Scheduler.CustomControl;
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
            Pass = SHA256.HashData(Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// 데이터를 읽어옴
        /// </summary>
        /// <param name="path"> 데이터를 읽어올 경로 </param>
        /// <param name="usedAES"> AES로 암호화 되었는 지 여부 </param>
        /// <returns> 데이터를 불러오는데 성공하였는 지 여부 </returns>
        public bool Load(string path, bool usedAES)
        {
            this.UsedPass = usedAES;

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
                while (true)
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
                        texts = Encoding.UTF8.GetString(dec).Split("\r\n");

                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid password!");
                        Debug.WriteLine(ex);

                        return false;
                    }
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

            this.UsedPass = usedAES;

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
                byte[] enc = aes.EncryptCbc(Encoding.UTF8.GetBytes(texts), Pass[0..16]);

                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(path)))
                {
                    writer.Write(enc);
                }
            }
        }

        /// <summary>
        /// 비밀번호 비교
        /// </summary>
        /// <param name="text"> 비교할 비밀번호 평문 </param>
        /// <returns> 해시 값을 비교, 새 비밀번호가 기존의 비밀번호와 일치하는 지 반환 </returns>
        public bool ComparePass(string text)
        {
            return Pass.Equals(SHA256.HashData(Encoding.UTF8.GetBytes(text)));
        }
    }
}
