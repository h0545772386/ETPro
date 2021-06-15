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
    /// AddressWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddressWindow : MetroWindow
    {
        public AddressWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double height = this.ActualHeight - 210;
            //height = height > 650 ? 650 : height;
            ContentRow.Height = new GridLength(height);
            System.Diagnostics.Debug.WriteLine($"{this.ActualHeight} ,{height}");
        }
    }
}
