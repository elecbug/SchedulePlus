using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Scheduler.Data
{
    public class Todo
    {
        public const int NOT_ACCOCIATE_TASK = -1;

        public long TaskId { get; set; } = NOT_ACCOCIATE_TASK;
        public bool IsCleared { get; set; } = false;
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public bool IsDDayTask { get; set; } = false;
        public List<int> ForeignTask { get; set; } = new List<int>();

        public string Serializing()
        {
            string json = JsonSerializer.Serialize(this);
            return json;
        }

        public Todo Deserializing(string json)
        {
            Todo result = JsonSerializer.Deserialize<Todo>(json) ?? throw new Exception("Format Error");
            return result;
        }
    }
}
