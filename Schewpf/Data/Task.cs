using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Schewpf.Data
{
    /// <summary>
    /// 할 일, 테스크
    /// </summary>
    public class Task
    {
        public const long NO_TASK = -1;

        /// <summary>
        /// 테스크마다 부여되는 고유의 ID
        /// </summary>
        public long TaskID { get; set; } = NO_TASK;
        /// <summary>
        /// 테스크가 완료 되었는 지 여부
        /// </summary>
        public bool IsCleared { get; set; } = false;
        /// <summary>
        /// 테스크의 날짜
        /// </summary>
        public DateTime DateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 테스크의 제목
        /// </summary>
        public string Title { get; set; } = "";
        /// <summary>
        /// 테스크의 상세 설명
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// D-Day Task 여부, 오늘의 할 일에 표시될 지 여부로 사용
        /// </summary>
        public bool IsDDayTask { get; set; } = false;
        /// <summary>
        /// 포함한 외부 테스크 키 리스트 - 미구현
        /// </summary>
        public List<int> ForeignTask { get; set; } = new List<int>();

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
        public Task Deserializing(string json)
        {
            Task result = JsonSerializer.Deserialize<Task>(json) ?? throw new Exception("Format Error");
            return result;
        }
    }
}
