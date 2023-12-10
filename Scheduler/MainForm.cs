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
        private long NowTaskId { get; set; } = Todo.NOT_TASK;
        private bool IsSaved { get; set; } = true;

        private const string EnterNewPass = "Enter the new password";
        private const string EnterBeforePass = "Enter the current password";

        public MainForm()
        {
            InitializeComponent();
            RefreshList();
            RefreshTreeView();
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

        private void TodoListBox_Format(object? sender, ListControlConvertEventArgs e)
        {
            Todo item = (Todo)e.ListItem!;
            e.Value = item.DateTime.ToString("yy-MM-dd") + " " + item.Title;
        }
        private void TodoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TodoListBox.Refresh();

            if (IsSaved == false 
                && MessageBox.Show("Do you want to save editing now?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SaveTodo();
            }

            RefreshTodo(this.TodoListBox.SelectedItem as Todo ?? null);
            IsSaved = true;
        }
        private void TodoListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Todo? item = (Todo?)this.TodoListBox.SelectedItem;

            if (item != null)
            {
                item.IsCleared = e.NewValue == CheckState.Checked;
                SaveTodo();
            }
        }

        private void RefreshList(bool sorted = false)
        {
            Todo? selected = (Todo?)this.TodoListBox.SelectedItem;

            this.TodoListBox.Items.Clear();

            if (sorted == true)
            {
                this.DataBook.Todos.Sort((x, y) => -x.DateTime.CompareTo(y.DateTime));
            }

            foreach (var item in this.DataBook.Todos)
            {
                if (item.IsCleared == false)
                    this.TodoListBox.Items.Add(item);
                else
                    this.TodoListBox.Items.Add(item, true);
            }
        }
        private void RefreshTreeView()
        {
            this.MainTreeView.Nodes.Clear();

            foreach (var todo in this.DataBook.Todos)
            {
                if ((todo.DateTime.Date <= DateTime.Now.Date
                    || todo.IsDDayTask == true)
                    && todo.IsCleared == false)
                {
                    this.MainTreeView.Nodes
                        .Add(todo.DateTime.ToString("yy-MM-dd") + " " + todo.Title);
                }
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
                this.NowTaskId = item.TaskId;
            }
            else
            {
                this.TodoDatePicker.Value = DateTime.Now;
                this.TitleTextBox.Text = "";
                this.DescryptTextBox.Text = "";
                this.DDayTaskButton.Checked = false;
                this.NowTaskId = Todo.NOT_TASK;
            }
        }
        private void SaveTodo()
        {
            Todo? item = this.DataBook.Todos.Where(x => x.TaskId == this.NowTaskId).FirstOrDefault();

            if (item != null)
            {
                this.TodoListBox.Refresh();

                item.DateTime = TodoDatePicker.Value;
                item.Title = this.TitleTextBox.Text;
                item.Description = this.DescryptTextBox.Text;
                item.IsDDayTask = this.DDayTaskButton.Checked;

                if (File.Exists(this.FilePath))
                    this.DataBook.Save(this.FilePath, this.DataBook.UsedPass);
            }

            RefreshTreeView();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close this?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.DataBook = new DataBook();

                RefreshList();
                RefreshTodo(null);

                this.FilePath = "";
            }
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close this?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
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

                        RefreshList();
                        RefreshTreeView();
                    }
                    else if (this.FilePath.Split('.').Last() == "esch")
                    {
                        PasswordForm form = new PasswordForm(EnterBeforePass);

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            this.DataBook.SetPass(form.PasswordBox.Text);
                            this.DataBook.Load(dialog.FileName, true);

                            RefreshList();
                            RefreshTreeView();
                        }
                    }
                }
            }
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.FilePath))
                this.DataBook.Save(this.FilePath, this.DataBook.UsedPass);
            else
                SaveAsToolStripMenuItem_Click(sender, e);

        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Schedule File|*.sch|AES Crypto Schedule File|*.esch",
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.FilePath = dialog.FileName;

                if (this.FilePath.Split('.').Last() == "sch")
                {
                    this.DataBook.UsedPass = false;
                    this.DataBook.Save(dialog.FileName, false);
                }
                else if (this.FilePath.Split('.').Last() == "esch")
                {
                    PasswordForm form = new PasswordForm(EnterNewPass);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.DataBook.UsedPass = true;
                        this.DataBook.SetPass(form.PasswordBox.Text);
                        this.DataBook.Save(dialog.FileName, true);

                        RefreshList();
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            long id = new Random().NextInt64();

            this.DataBook.Todos.Add(new Todo
            {
                TaskId = id,
            });

            SaveTodo();
            RefreshList();

            this.TodoListBox.SelectedIndex = this.DataBook.Todos.Count - 1;
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Todo? item = (Todo?)this.TodoListBox.SelectedItem;

            if (item != null)
            {
                this.DataBook.Todos.Remove(item);

                SaveTodo();
                RefreshList();
                RefreshTodo(null);
            }
        }
        private void SortButton_Click(object sender, EventArgs e)
        {
            RefreshList(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveTodo();
            IsSaved = true;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (IsSaved == false 
                && MessageBox.Show("Do you want to cancel editing?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                RefreshTodo(null);

                IsSaved = true;
            }
        }

        private void Todo_Editted(object sender, EventArgs e)
        {
            IsSaved = false;
        }
    }
}