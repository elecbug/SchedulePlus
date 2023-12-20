using Microsoft.Win32;
using Schewpf.Data;
using Schewpf.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Schewpf.Windows
{
    /// <summary>
    /// Interaction logic for TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public DataBook DataBook = new DataBook();
        private long SelectedTaskID = Task.NO_TASK;
        private bool IsSaved = true;

        /// <summary>
        /// 창을 열 때 호출, 미리 저장된 파일 경로가 있다면 그 파일을 열고, 
        /// 경로가 없거나 파일을 찾을 수 없다면 File Dialog를 호출
        /// </summary>
        public TaskPage()
        {
            InitializeComponent();

            Opening();
        }

        /// <summary>
        /// 파일을 찾을 수 없을 때 다이얼로그를 띄워 파일 위치를 지정
        /// </summary>
        /// <param name="showDialog"> 반드시 다이얼로그를 띄움 </param>
        private void Opening(bool showDialog = false)
        {
            if (File.Exists(User.Default.FilePath) == false || showDialog == true)
            {
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Filter = "Scheduler File|*.sch",
                };

                if (dialog.ShowDialog() == true)
                {
                    User.Default.FilePath = dialog.FileName;
                    User.Default.Save();
                }
            }

            if (DataBook.Load(User.Default.FilePath) == false)
            {
                MessageBox.Show(User.Default.FilePath + " is corrupted!");

                DataBook.Reset();
            }

            RefreshByDataBook();
            IsSaved = true;
        }

        /// <summary>
        /// 데이터 북에 기반하여 화면을 재설정
        /// </summary>
        private void RefreshByDataBook()
        {
            RefreshTreeView();
            RefreshListView();
            RefreshTaskPanel();
            //RefreshMemoFrame();
        }

        /// <summary>
        /// 할 일을 표시하는 패널의 하위 요소만을 재설정
        /// </summary>
        private void RefreshTaskPanel()
        {
            Task? item = DataBook.Tasks.FirstOrDefault(x => x.TaskID == SelectedTaskID);

            if (item != null)
            {
                TaskDateTimePicker.SelectedDate = item.DateTime;
                TaskTitleTextBox.Text = item.Title;
                TaskDescryptTextBox.Text = item.Description;
                TaskDDayCheckBox.IsChecked = item.IsDDayTask;
            }
            else
            {
                TaskDateTimePicker.SelectedDate = DateTime.Now;
                TaskTitleTextBox.Text = "";
                TaskDescryptTextBox.Text = "";
                TaskDDayCheckBox.IsChecked = false;
            }
        }

        /// <summary>
        /// 할 일 리스트 두 가지를 재설정
        /// </summary>
        private void RefreshListView()
        {
            BeforeTaskListView.Items.Clear();
            AfterTaskListView.Items.Clear();

            foreach (var item in DataBook.Tasks)
            {
                if (item.IsCleared == true)
                {
                    AfterTaskListView.Items.Add(new TaskListItem(item, item.IsCleared,
                        (s, e) =>
                        {
                            item.IsCleared = false;

                            DataBook.Save(User.Default.FilePath);
                            RefreshByDataBook();
                        },
                        (s, e) =>
                        {
                            if (MessageBox.Show("Remove this?", "", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                            {
                                if (SelectedTaskID == item.TaskID)
                                {
                                    SelectedTaskID = -1;
                                }

                                DataBook.Tasks.Remove(item);
                                DataBook.Save(User.Default.FilePath);

                                RefreshByDataBook();

                                IsSaved = true;
                            }
                        }));
                }
                else
                {
                    BeforeTaskListView.Items.Add(new TaskListItem(item, item.IsCleared,
                        (s, e) =>
                        {
                            item.IsCleared = true;

                            DataBook.Save(User.Default.FilePath);
                            RefreshByDataBook();
                        },
                        (s, e) =>
                        {
                            if (MessageBox.Show("Remove this?", "", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                            {
                                if (SelectedTaskID == item.TaskID)
                                {
                                    SelectedTaskID = -1;
                                }

                                DataBook.Tasks.Remove(item);
                                DataBook.Save(User.Default.FilePath);

                                RefreshByDataBook();

                                IsSaved = true;
                            }
                        }));
                }
            }
        }

        /// <summary>
        /// 오늘 할 일의 목록을 재설정
        /// </summary>
        private void RefreshTreeView()
        {
            TaskTreeView.Items.Clear();

            foreach (var todo in DataBook.Tasks)
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

                    TaskTreeView.Items.Add(new Label()
                    {
                        Content = todo.DateTime.ToString("yy-MM-dd") + " " + todo.Title
                            + (todo.IsDDayTask == true ? " (D" + dayStr + ")" : ""),
                    });
                }
            }
        }

        /// <summary>
        /// 테스크를 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskSaveButton_Click(object sender, RoutedEventArgs e)
        {
            Task? item = DataBook.Tasks.FirstOrDefault(x => x.TaskID == SelectedTaskID);

            if (item != null)
            {
                item.DateTime = TaskDateTimePicker.SelectedDate ?? DateTime.Now;
                item.Title = TaskTitleTextBox.Text;
                item.Description = TaskDescryptTextBox.Text;
                item.IsDDayTask = TaskDDayCheckBox.IsChecked == true;

                DataBook.Save(User.Default.FilePath);
                this.IsSaved = true;

                RefreshByDataBook();
            }
        }

        /// <summary>
        /// 테스크 편집을 취소
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskCancelButton_Click(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// 완료 전 테스크 중 하나를 선택하면 테스크 패널의 정보를 채우며 테스크가 이동함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeforeTaskListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsSaved == false)
            {
                if (MessageBox.Show("Are you sure you want to save the changes?", "",
                    MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    Task? task = DataBook.Tasks.FirstOrDefault(x => x.TaskID == SelectedTaskID);

                    if (task != null)
                    {
                        task.DateTime = TaskDateTimePicker.DisplayDate;
                        task.Title = TaskTitleTextBox.Text;
                        task.Description = TaskDescryptTextBox.Text;
                        task.IsDDayTask = TaskDDayCheckBox.IsChecked == true;

                        DataBook.Save(User.Default.FilePath);
                    }
                }
            }

            TaskListItem? item = BeforeTaskListView.SelectedItem as TaskListItem;

            if (item != null)
            {
                SelectedTaskID = item.Task.TaskID;

                RefreshTaskPanel();
            }

            IsSaved = true;
        }

        /// <summary>
        /// 완료 후 테스크 중 하나를 선택하면 테스크 패널의 정보를 채우며 테스크가 이동함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfterTaskListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsSaved == false)
            {
                if (MessageBox.Show("Are you sure you want to save the changes?", "",
                    MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    Task? task = DataBook.Tasks.FirstOrDefault(x => x.TaskID == SelectedTaskID);

                    if (task != null)
                    {
                        task.DateTime = TaskDateTimePicker.DisplayDate;
                        task.Title = TaskTitleTextBox.Text;
                        task.Description = TaskDescryptTextBox.Text;
                        task.IsDDayTask = TaskDDayCheckBox.IsChecked == true;

                        DataBook.Save(User.Default.FilePath);
                    }
                }
            }

            TaskListItem? item = AfterTaskListView.SelectedItem as TaskListItem;

            if (item != null)
            {
                SelectedTaskID = item.Task.TaskID;

                RefreshTaskPanel();
            }

            IsSaved = true;
        }

        /// <summary>
        /// 테스크가 수정된 후 저장되었는 지 확인하기 위한 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Task_Editted()
        {
            IsSaved = false;
        }

        /// <summary>
        /// 테스크 패널 내 값 변경 시 IsSaved를 false로 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskDateTimePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Task_Editted();
        }

        /// <summary>
        /// 테스크 패널 내 값 변경 시 IsSaved를 false로 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskTitleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Task_Editted();
        }

        /// <summary>
        /// 테스크 패널 내 값 변경 시 IsSaved를 false로 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskDescryptTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Task_Editted();
        }

        /// <summary>
        /// 테스크 패널 내 값 변경 시 IsSaved를 false로 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskDDayCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Task_Editted();
        }

        /// <summary>
        /// 테스크를 추가하는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskAddButton_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task()
            {
                TaskID = new Random().NextInt64(),
                DateTime = DateTime.Now,
                Title = "",
                Description = "",
                IsCleared = false,
                IsDDayTask = false,
                ForeignTask = new List<int>(),
            };

            DataBook.Tasks.Add(task);
            DataBook.Save(User.Default.FilePath);

            SelectedTaskID = task.TaskID;
            RefreshByDataBook();

            IsSaved = true;
        }

        /// <summary>
        /// 파일 바꾸기 버튼을 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Opening(true);
        }

        /// <summary>
        /// 파일을 새로 생성하는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileAddButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Scheduler File|*.sch",
            };

            if (dialog.ShowDialog() == true)
            {
                User.Default.FilePath = dialog.FileName;
                User.Default.Save();
            }

            DataBook.Reset();
            DataBook.Save(User.Default.FilePath);

            RefreshByDataBook();
            IsSaved = true;
        }
    }
}
