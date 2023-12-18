using Microsoft.Win32;
using Schewpf.Data;
using Schewpf.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Schewpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataBook DataBook = new DataBook();

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 창을 열 때 호출, 미리 저장된 파일 경로가 있다면 그 파일을 열고, 
        /// 경로가 없거나 파일을 찾을 수 없다면 File Dialog를 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(User.Default.FilePath))
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
                MessageBox.Show(User.Default.FilePath + "is corrupted!");

                DataBook.Reset();
            }

            RefreshByDataBook();
        }

        /// <summary>
        /// 데이터 북에 기반하여 화면을 재설정
        /// </summary>
        private void RefreshByDataBook()
        {
            RefreshTreeView();
            RefreshListView();
            RefreshTaskFrame();
            RefreshMemoFrame();
        }

        /// <summary>
        /// 메모 프레임만을 재설정
        /// </summary>
        private void RefreshMemoFrame()
        {
        }

        /// <summary>
        /// 할 일을 표시하는 프레임의 하위 요소만을 재설정
        /// </summary>
        private void RefreshTaskFrame()
        {
        }

        /// <summary>
        /// 할 일 리스트 두 가지를 재설정
        /// </summary>
        private void RefreshListView()
        {
        }

        /// <summary>
        /// 오늘 할 일의 목록을 재설정
        /// </summary>
        private void RefreshTreeView()
        {
        }
    }
}
