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
    /// Interaction logic for InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        /// <summary>
        /// 테스크 쪽에서 생성해서 받아온 데이터
        /// </summary>
        public DataBook DataBook { get; private set; }


        public InfoPage(DataBook data)
        {
            InitializeComponent();
        
            DataBook = data;
            RefreshInfoList();
        }

        private void RefreshInfoList()
        {
            InfoListView.Items.Clear();

            foreach (var item in DataBook.Infos)
            {
                InfoListView.Items.Add(item);
            }
        }
    }
}
