using Schewpf.Data;
using System;
using System.Collections.Generic;
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

namespace Schewpf.Windows
{
    /// <summary>
    /// Interaction logic for MemoPage.xaml
    /// </summary>
    public partial class MemoPage : Page
    {
        public DataBook DataBook { get; private set; }

        public MemoPage(DataBook data)
        {
            InitializeComponent();

            DataBook = data;
            RefreshMemoFrame();
        }


        /// <summary>
        /// 메모 프레임만을 재설정
        /// </summary>
        private void RefreshMemoFrame()
        {
            MemoCanvas.Children.Clear();

            foreach (var item in DataBook.Memos)
            {
                AddMemoLabel(item);
            }
        }

        /// <summary>
        /// Memo 객체를 기반으로 메모를 UI에 그림
        /// </summary>
        /// <param name="item"> 메모 </param>
        private void AddMemoLabel(Memo item)
        {
            Label label = new Label()
            {
                Visibility = Visibility.Visible,
                Content = item.Text,
                Background = new SolidColorBrush(Colors.LightGoldenrodYellow),
            };

            MemoCanvas.Children.Add(label);

            Canvas.SetLeft(label, (double)item.X);
            Canvas.SetTop(label, (double)item.Y);
        }
    }
}
