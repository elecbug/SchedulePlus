using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Schewpf.Data
{
    public class Memo
    {
        public const int NO_MEMO = -1;

        /// <summary>
        /// 메모마다 부여되는 고유의 ID
        /// </summary>
        public long MemoID { get; set; } = NO_MEMO; 
        /// <summary>
        /// 메모가 고정되는 X 좌표
        /// </summary>
        public int X { get; set; } = 0;
        /// <summary>
        /// 메모가 고정되는 Y 좌표
        /// </summary>
        public int Y { get; set; } = 0;
        /// <summary>
        /// 메모 내용
        /// </summary>
        public string Text { get; set; } = "";

        /// <summary>
        /// 데이터 직렬화
        /// </summary>
        /// <returns> 직렬화 된 데이터 </returns>
        public string Serializing()
        {
            string json = JsonSerializer.Serialize(this);
            return json;
        }

        /// <summary>
        /// 데이터 역직렬화
        /// </summary>
        /// <param name="json"> 직렬화 된 데이터 </param>
        /// <returns> 직렬화 된 데이터를 Todo 타입으로 변환 </returns>
        /// <exception cref="Exception"></exception>
        public Memo Deserializing(string json)
        {
            Memo result = JsonSerializer.Deserialize<Memo>(json) ?? throw new Exception("Format Error");
            return result;
        }
    }
}
