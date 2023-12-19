using Microsoft.Win32;
using Schewpf.Data;
using Schewpf.Settings;
using Schewpf.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TaskPage mainPage = new TaskPage();
            TaskFrame.Content = mainPage;
            MemoFrame.Content = new MemoPage(mainPage.DataBook);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Close Window?", "", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
