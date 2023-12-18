using Microsoft.Win32;
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
        public MainWindow()
        {
            InitializeComponent();
        }

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
        }
    }
}
