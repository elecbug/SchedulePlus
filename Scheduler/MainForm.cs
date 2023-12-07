using Scheduler.CustomControl;
using Scheduler.Data;
using System.Security.Cryptography;
using System.Text;

namespace Scheduler
{
    public partial class MainForm : Form
    {
        public string FilePath { get; set; } = "";
        public DataBook DataBook { get; private set; } = new DataBook();

        public MainForm()
        {
            InitializeComponent();
            RefreshList();

            this.TodoListBox.Format += TodoListBox_Format;
        }

        private void TodoListBox_Format(object? sender, ListControlConvertEventArgs e)
        {
            Todo item = (Todo)e.ListItem!;
            e.Value = item.DateTime.ToString("yy-MM-dd") + " " + item.Title;
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

        private void RefreshList()
        {
            this.TodoListBox.Items.Clear();

            foreach (var item in this.DataBook.Todos)
            {
                if (item.IsCleared == false)
                    this.TodoListBox.Items.Add(item);
                else
                    this.TodoListBox.Items.Add(item, true);
            }
        }
        private void RefreshTodo(Todo? item)
        {
            if (item != null)
            {
                this.TodoDatePicker.Value = item.DateTime;
                this.TitleTextBox.Text = item.Title;
                this.DescryptTextBox.Text = item.Description;
                this.DDayTaskButton.Checked = item.IsDDayTask;
            }
            else
            {
                this.TodoDatePicker.Value = DateTime.Now;
                this.TitleTextBox.Text = "";
                this.DescryptTextBox.Text = "";
                this.DDayTaskButton.Checked = false;
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Schedule File|*.sch;*.esch",
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.FilePath = dialog.FileName;

                if (this.FilePath.Split('.').Last() == "sch")
                {
                    this.DataBook.Load(dialog.FileName, false);
                }
                else if (this.FilePath.Split('.').Last() == "esch")
                {
                    PasswordForm form = new PasswordForm();

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.DataBook.SetPass(form.Password.Text);
                        this.DataBook.Load(dialog.FileName, true);

                        RefreshList();
                    }
                }
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TodoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTodo(this.TodoListBox.SelectedItem as Todo ?? null);
        }
    }
}