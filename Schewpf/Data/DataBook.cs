using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        public List<Task> Todos { get; private set; } = new List<Task>();
        /// <summary>
        /// 메모 목록
        /// </summary>
        public List<Memo> Memos { get; private set; } = new List<Memo>();

        /// <summary>
        /// 데이터를 읽어옴
        /// </summary>
        /// <param name="path"> 데이터를 읽어올 경로 </param>
        /// <returns> 데이터를 불러오는데 성공하였는 지 여부 </returns>
        public bool Load(string path)
        {
            string[] texts;

            using (StreamReader reader = new StreamReader(path))
            {
                texts = reader.ReadToEnd().Split("\r\n");
            }

            Todos = JsonSerializer.Deserialize<List<Task>>(texts[0]) ?? new List<Task>();
            Memos = JsonSerializer.Deserialize<List<Memo>>(texts[1]) ?? new List<Memo>();

            return true;
        }

        /// <summary>
        /// 데이터를 저장함
        /// </summary>
        /// <param name="path"> 데이터를 저장할 경로 </param>
        public void Save(string path)
        {
            if (File.Exists(path) == false)
            {
                File.Create(path).Close();
            }

            string texts =
                JsonSerializer.Serialize(Todos) + "\r\n" +
                JsonSerializer.Serialize(Memos) + "\r\n";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(texts);
            }
        }
    }
}
