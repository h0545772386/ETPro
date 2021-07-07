using MahApps.Metro.Controls;
using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace ETPro
{
    /// <summary>
    /// DocWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DocWindow : MetroWindow
    {
        public DocWindow()
        {
            InitializeComponent();
            cbObjType.ItemsSource = new ETPro.Classes.LSaverities();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BBrowers_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog().Value)
            {
                tbDocPath.Text = openFileDialog.FileName;
            }
        }
    }
}
