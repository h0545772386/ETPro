using MahApps.Metro.Controls;
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
    /// ClntOrderWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ClntOrderWindow : MetroWindow
    {
        public ClntOrderWindow()
        {
            InitializeComponent();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BSwich_Click(object sender, RoutedEventArgs e)
        {
            string str = tbToLocation.Text;
            tbToLocation.Text = tbFromLocation.Text;
            tbFromLocation.Text = str;
        }
    }
}
