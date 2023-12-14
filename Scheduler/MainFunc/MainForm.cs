using Scheduler.CustomControl;
using Scheduler.Data;
using System.Diagnostics;
using System.Text;

namespace Scheduler.MainFunc
{
    /// <summary>
    /// 메인 폼 부분
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// 현재 파일의 경로
        /// </summary>
        public string FilePath { get; set; } = "";
        /// <summary>
        /// 현재 열려있는 데이터 북
        /// </summary>
        public DataBook DataBook { get; private set; } = new DataBook();
        /// <summary>
        /// 현재 선택된 테스크의 ID, Detail View에서 표시되는 테스크의 ID임
        /// </summary>
        private long NowTaskId { get; set; } = Todo.NOT_TASK;
        /// <summary>
        /// 현재 데이터가 저장된 이후 수정이 더 가해지지 않은 상태인 지의 여부
        /// </summary>
        private bool IsSaved { get; set; } = true;

        private const string EnterNewPass = "Enter the new password";
        private const string EnterBeforePass = "Enter the current password";

        public MainForm(string path)
        {
            InitializeComponent();

            Font = Properties.Data.Default.Font;
            TitleTextBox.LanguageOption = RichTextBoxLanguageOptions.AutoFont;
            DescryptTextBox.LanguageOption = RichTextBoxLanguageOptions.AutoFont;
            MemoTextBox.LanguageOption = RichTextBoxLanguageOptions.AutoFont;

            if (path != "")
            {
                FilePath = path;

                if (FilePath.Split('.').Last() == "sch")
                {
                    DataBook.Load(path, false);
                }
                else if (FilePath.Split('.').Last() == "esch")
                {
                    PasswordForm form = new PasswordForm(EnterBeforePass);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        DataBook.SetPass(form.PasswordBox.Text);

                        if (DataBook.Load(FilePath, true) == true)
                        {
                            RefreshList();
                            RefreshTreeView();

                            DataBook.SetPass("");
                            FilePath = FilePath + ".sch";
                            DataBook.Save(FilePath, false);
                        }
                    }
                }
            }

            RefreshList();
            RefreshTreeView();
            RefreshMemo();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Close the Window?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
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
            data.SetPass("lol");

            data.Save(Environment.CurrentDirectory + "\\test.sch", true);
            DataBook refresh = new DataBook();
            refresh.SetPass("lol");
            refresh.Load(Environment.CurrentDirectory + "\\test.sch", true);
        }

        private void RefreshList(bool sorted = false)
        {
            Todo? selected = (Todo?)TodoListBox.SelectedItem;

            TodoListBox.Items.Clear();

            if (sorted == true)
            {
                DataBook.Todos.Sort((x, y) => -x.DateTime.CompareTo(y.DateTime));
            }

            foreach (var item in DataBook.Todos)
            {
                if (item.IsCleared == false)
                {
                    TodoListBox.Items.Add(item);
                }
                else
                {
                    TodoListBox.Items.Add(item, true);
                }
            }
        }
        private void RefreshTreeView()
        {
            MainTreeView.Nodes.Clear();

            foreach (var todo in DataBook.Todos)
            {
                if ((todo.DateTime.Date <= DateTime.Now.Date
                    || todo.IsDDayTask == true)
                    && todo.IsCleared == false)
                {
                    int day = (DateTime.Now.Date - todo.DateTime.Date).Days;
                    string dayStr;

                    if (day > 0)
                    {
                        dayStr = "+" + day;
                    }
                    else if (day < 0)
                    {
                        dayStr = "" + day;
                    }
                    else
                    {
                        dayStr = "-Day";
                    }

                    MainTreeView.Nodes
                        .Add(todo.DateTime.ToString("yy-MM-dd") + " " + todo.Title
                            + (todo.IsDDayTask == true ? " (D" + dayStr + ")" : ""));
                }
            }
        }
        private void RefreshTodo(Todo? item)
        {
            if (item != null)
            {
                TodoDatePicker.Value = item.DateTime;
                TitleTextBox.Text = item.Title;
                DescryptTextBox.Text = item.Description;
                DDayTaskButton.Checked = item.IsDDayTask;
                NowTaskId = item.TaskId;
            }
            else
            {
                TodoDatePicker.Value = DateTime.Now;
                TitleTextBox.Text = "";
                DescryptTextBox.Text = "";
                DDayTaskButton.Checked = false;
                NowTaskId = Todo.NOT_TASK;
            }
        }
        private void RefreshMemo()
        {
            DrawingPanel.Controls.Clear();

            foreach (var item in DataBook.Memos)
            {
                Label label = new Label()
                {
                    Parent = DrawingPanel,
                    Visible = true,
                    Location = new Point(item.X, item.Y),
                    Text = item.Text,
                    AutoSize = true,
                    BackColor = Color.LightGoldenrodYellow,
                };
                label.MouseClick += DrawingPanel_Memo_Click;
                label.MouseDown += DrawingPanel_Memo_MouseDown;
                label.MouseUp += DrawingPanel_Memo_MouseUp;
                label.MouseMove += DrawingPanel_Memo_MouseMove;
            }
        }

        private void SaveTodo()
        {
            try
            {
                Todo? item = DataBook.Todos.Where(x => x.TaskId == NowTaskId).FirstOrDefault();

                if (item != null)
                {
                    TodoListBox.Refresh();

                    item.DateTime = TodoDatePicker.Value;
                    item.Title = TitleTextBox.Text;
                    item.Description = DescryptTextBox.Text;
                    item.IsDDayTask = DDayTaskButton.Checked;
                }

                DataBook.Save(FilePath, DataBook.UsedPass);
                Debug.WriteLine(Encoding.UTF8.GetString(DataBook.Pass) + DataBook.UsedPass);

                RefreshTreeView();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
        private void SaveMemo()
        {
            try
            {
                DataBook.Save(FilePath, DataBook.UsedPass);
                Debug.WriteLine(Encoding.UTF8.GetString(DataBook.Pass) + DataBook.UsedPass);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void TodoListBox_Format(object? sender, ListControlConvertEventArgs e)
        {
            Todo item = (Todo)e.ListItem!;
            e.Value = item.DateTime.ToString("yy-MM-dd") + " " + item.Title;
        }
        private void TodoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TodoListBox.Refresh();

            if (IsSaved == false
                && MessageBox.Show("Do you want to save editing now?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SaveTodo();
            }

            RefreshTodo(TodoListBox.SelectedItem as Todo ?? null);

            IsSaved = true;
        }
        private void TodoListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Todo? item = (Todo?)TodoListBox.SelectedItem;

            if (item != null)
            {
                item.IsCleared = e.NewValue == CheckState.Checked;
            }

            SaveTodo();
        }

        private void TodoAddButton_Click(object sender, EventArgs e)
        {
            long id = new Random().NextInt64();

            DataBook.Todos.Add(new Todo()
            {
                TaskId = id,
            });

            SaveTodo();
            RefreshList();

            TodoListBox.SelectedIndex = DataBook.Todos.Count - 1;
        }
        private void TodoRemoveButton_Click(object sender, EventArgs e)
        {
            Todo? item = (Todo?)TodoListBox.SelectedItem;

            if (item != null)
            {
                DataBook.Todos.Remove(item);

                SaveTodo();
                RefreshList();
                RefreshTodo(null);

                IsSaved = true;
            }
        }
        private void TodoSortButton_Click(object sender, EventArgs e)
        {
            RefreshList(true);
            SaveTodo();
        }

        private void TodoSaveButton_Click(object sender, EventArgs e)
        {
            SaveTodo();
            TodoListBox.Refresh();
            IsSaved = true;
        }
        private void TodoCancelButton_Click(object sender, EventArgs e)
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

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close this?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataBook = new DataBook();

                RefreshList();
                RefreshTodo(null);
                RefreshMemo();

                FilePath = "";
            }
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Schedule File|*.sch;*.esch",
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;

                if (FilePath.Split('.').Last() == "sch")
                {
                    DataBook.Load(dialog.FileName, false);

                    RefreshList();
                    RefreshTreeView();
                    RefreshMemo();
                }
                else if (FilePath.Split('.').Last() == "esch")
                {
                    PasswordForm form = new PasswordForm(EnterBeforePass);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        DataBook.SetPass(form.PasswordBox.Text);

                        if (DataBook.Load(dialog.FileName, true) == true)
                        {
                            RefreshList();
                            RefreshTreeView();
                            RefreshMemo();

                            DataBook.SetPass("");
                            FilePath = FilePath + ".sch";
                            DataBook.Save(FilePath, false);
                        }
                    }
                }
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Schedule File|*.sch",
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;
                DataBook.UsedPass = false;
                DataBook.Save(dialog.FileName, false);
            }
        }
        private void ExportAESFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "AES Encrypted Schedule File|*.esch",
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string nowPath = FilePath;

                FilePath = dialog.FileName;

                PasswordForm form = new PasswordForm(EnterNewPass);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    DataBook.UsedPass = true;
                    DataBook.SetPass(form.PasswordBox.Text);
                    DataBook.Save(dialog.FileName, true);

                    RefreshList();
                }

                DataBook.UsedPass = false;
                DataBook.SetPass("");
                FilePath = nowPath;
            }
        }
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog()
            {
                Font = Font,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Font = dialog.Font;

                Properties.Data.Default.Font = Font;
                Properties.Data.Default.Save();
            }
        }
        private void TopMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;

            Opacity = TopMost == true ? 0.85 : 1.0;
        }

        /// <summary>
        /// 패널 클릭 당시 마우스의 위치, 메모를 움직이는데 사용
        /// </summary>
        private Point NowMouse { get; set; } = new Point();
        /// <summary>
        /// 하나의 레이블만을 옮길 경우 해당 레이블을 의미하는 메모
        /// </summary>
        private LabelWrapper NowLabel { get; set; } = new LabelWrapper();
        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DrawingPanel_DoubleClick(object sender, EventArgs e)
        {
            if (MemoTextBox.Text == "")
            {
                return;
            }

            Label label = new Label()
            {
                Parent = DrawingPanel,
                Visible = true,
                Text = MemoTextBox.Text,
                Location = DrawingPanel.PointToClient(MousePosition),
                AutoSize = true,
                BackColor = Color.LightGoldenrodYellow,
            };
            label.MouseClick += DrawingPanel_Memo_Click;
            label.MouseDown += DrawingPanel_Memo_MouseDown;
            label.MouseUp += DrawingPanel_Memo_MouseUp;
            label.MouseMove += DrawingPanel_Memo_MouseMove;

            DataBook.Memos.Add(new LabelWrapper()
            {
                X = label.Location.X,
                Y = label.Location.Y,
                Text = label.Text,
            });

            SaveMemo();
            MemoTextBox.Text = "";
        }
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouse = DrawingPanel.PointToClient(MousePosition);
                Point delta = new Point(mouse.X - NowMouse.X, mouse.Y - NowMouse.Y);

                for (int i = 0; i < DrawingPanel.Controls.Count; i++)
                {
                    Control item = (DrawingPanel.Controls[i] as Control)!;

                    item.Location = new Point(DataBook.Memos[i].X + delta.X, DataBook.Memos[i].Y + delta.Y);
                }
            }
        }
        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NowMouse = DrawingPanel.PointToClient(MousePosition);

                Cursor.Current = Cursors.Hand;
            }
        }
        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < DrawingPanel.Controls.Count; i++)
                {
                    Control item = (DrawingPanel.Controls[i] as Control)!;

                    DataBook.Memos[i].X = item.Location.X;
                    DataBook.Memos[i].Y = item.Location.Y;
                }

                SaveMemo();
                Cursor.Current = Cursors.Default;
            }
        }

        private void DrawingPanel_Memo_Click(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip strip = new ContextMenuStrip();

                strip.Items.Add("Remove").Click += (s, e) =>
                {
                    Label sen = (sender as Label)!;
                    LabelWrapper item = DataBook.Memos.Find(x => x.Text == sen.Text && new Point(x.X, x.Y) == sen.Location)!;

                    DataBook.Memos.Remove(item);
                    SaveMemo();

                    DrawingPanel.Controls.Remove(sen);
                    sen.Visible = false;
                };

                strip.Items.Add("Copy to Text Box").Click += (s, e) =>
                {
                    Label sen = (sender as Label)!;
                    MemoTextBox.Text = sen.Text;
                };

                strip.Show(MousePosition);
            }
        }
        private void DrawingPanel_Memo_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouse = DrawingPanel.PointToClient(MousePosition);
                Point delta = new Point(mouse.X - NowMouse.X, mouse.Y - NowMouse.Y);

                Control item = (sender as Control)!;

                item.Location = new Point(NowLabel.X + delta.X, NowLabel.Y + delta.Y);
            }
        }
        private void DrawingPanel_Memo_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control item = (sender as Control)!;

                NowLabel.X = item.Location.X;
                NowLabel.Y = item.Location.Y;

                SaveMemo();
                Cursor.Current = Cursors.Default;
            }
        }
        private void DrawingPanel_Memo_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control item = (sender as Control)!;

                NowMouse = DrawingPanel.PointToClient(MousePosition);
                NowLabel = DataBook.Memos
                    .Find(x => x.Text == item.Text && new Point(x.X, x.Y) == item.Location)!;

                Cursor.Current = Cursors.Hand;
            }
        }
    }
}