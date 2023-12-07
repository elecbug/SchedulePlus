using Scheduler.Data;
using System.Security.Cryptography;
using System.Text;

namespace Scheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AddTestData();
        }

        private void AddTestData()
        {
            var data = new DataBook();
            data.Todos.Add(new Todo()
            {
                Title = "Title test",
                DateTime = DateTime.Now,
                Description = "Descry test",
                ForeignTask = new List<int> { 1, 2, 3 },
                IsDDayTask = true,
                TaskId = 1,
            });
            data.Todos.Add(new Todo()
            {
                Title = "Title test2",
                DateTime = DateTime.Now,
                Description = "Descry test2",
                ForeignTask = new List<int> { 1, 2, 3, 4 },
                IsDDayTask = false,
                TaskId = 3,
            });
            data.Memos.Add("Hello");
            data.Memos.Add("Mom");
            data.SetPass("lol");

            data.Save(Environment.CurrentDirectory + "\\test.sch", true);
            var refresh = new DataBook();
            refresh.SetPass("lol");
            refresh.Load(Environment.CurrentDirectory + "\\test.sch", true);
        }
    }
}