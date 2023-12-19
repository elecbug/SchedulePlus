using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Schewpf.Data
{
    /// <summary>
    /// 파일 하나 단위와 같은 데이터 북
    /// </summary>
    public class DataBook
    {
        /// <summary>
        /// 할 일 목록
        /// </summary>
        public List<Task> Tasks { get; private set; } = new List<Task>();
        /// <summary>
        /// 메모 목록
        /// </summary>
        public List<Memo> Memos { get; private set; } = new List<Memo>();
        /// <summary>
        /// 사람들의 정보를 기록하는 목록
        /// </summary>
        public List<Info> Infos { get; private set; } = new List<Info>();

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

            try
            {
                Tasks = JsonSerializer.Deserialize<List<Task>>(texts[0]) ?? new List<Task>();
                Memos = JsonSerializer.Deserialize<List<Memo>>(texts[1]) ?? new List<Memo>();
                Infos = JsonSerializer.Deserialize<List<Info>>(texts[2]) ?? new List<Info>();

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            
                return false;
            }
        }

        /// <summary>
        /// 데이터를 저장함
        /// </summary>
        /// <param name="path"> 데이터를 저장할 경로 </param>
        public void Save(string path)
        {
            Tasks.Sort((x, y) => y.DateTime.CompareTo(x.DateTime));

            if (File.Exists(path) == false)
            {
                File.Create(path).Close();
            }

            string texts =
                JsonSerializer.Serialize(Tasks) + "\r\n" +
                JsonSerializer.Serialize(Memos) + "\r\n" +
                JsonSerializer.Serialize(Infos);

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(texts);
            }
        }

        /// <summary>
        /// 기본 데이터 북으로 초기화 함
        /// </summary>
        public void Reset()
        {
            Tasks = new List<Task>();
            Memos = new List<Memo>();
            Infos = new List<Info>();
        }
    }
}
