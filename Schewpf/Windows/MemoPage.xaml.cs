using Schewpf.Data;
using Schewpf.Settings;
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
        private class MemoLabel : Label
        {
            public long MemoID { get; set; }
        }

        /// <summary>
        /// 테스크 쪽에서 생성해서 받아온 데이터
        /// </summary>
        public DataBook DataBook { get; private set; }

        /// <summary>
        /// 데이터 북을 받아와서 끼움
        /// </summary>
        /// <param name="data"> 받아온 데이터 북</param>
        public MemoPage(DataBook data)
        {
            InitializeComponent();

            DataBook = data;
            RefreshMemoCanvas();
        }


        /// <summary>
        /// 메모 프레임만을 재설정
        /// </summary>
        private void RefreshMemoCanvas()
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
            MemoLabel label = new MemoLabel()
            {
                MemoID = item.MemoID,
                Visibility = Visibility.Visible,
                Content = item.Text,
                Background = new SolidColorBrush(Colors.LightGoldenrodYellow),
            };

            MemoCanvas.Children.Add(label);

            label.MouseDoubleClick += Label_MouseDoubleClick;
            label.MouseDown += Label_MouseDown;

            Canvas.SetLeft(label, (double)item.X);
            Canvas.SetTop(label, (double)item.Y);
        }

        /// <summary>
        /// 우클릭을 한번만 하여 메모의 내용을 텍스트 상자로 반환
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                MemoLabel label = (MemoLabel)sender;

                MemoTextBox.Text = label.Content.ToString();
            }
        }

        /// <summary>
        /// 메모를 지울지 물어보는 창 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                MemoLabel label = (MemoLabel)sender;

                Memo memo = DataBook.Memos.First(x => x.MemoID == label.MemoID);

                DataBook.Memos.Remove(memo);
                DataBook.Save(User.Default.FilePath);

                RefreshMemoCanvas();
            }
        }

        /// <summary>
        /// 텍스트 박스의 내용을 기반으로 캔버스 클릭 시 메모 생성 및 텍스트 상자 비우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemoCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && MemoTextBox.Text != "")
            {
                DataBook.Memos.Add(new Memo()
                {
                    MemoID = new Random().NextInt64(),
                    Text = MemoTextBox.Text,
                    X = (int)e.GetPosition(MemoCanvas).X,
                    Y = (int)e.GetPosition(MemoCanvas).Y
                });

                DataBook.Save(User.Default.FilePath);

                MemoTextBox.Text = "";

                RefreshMemoCanvas();
            }
        }
    }
}
