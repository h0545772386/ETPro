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
    /// UserWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UserWindow : MetroWindow
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void titalAddress_Click(object sender, RoutedEventArgs e)
        {
            AddressWindow addressWindow = new AddressWindow();
            addressWindow.Owner = this;
            addressWindow.ShowDialog();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
