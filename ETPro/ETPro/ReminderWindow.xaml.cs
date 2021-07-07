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
    /// ReminderWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ReminderWindow : MetroWindow
    {
        public ReminderWindow()
        {
            InitializeComponent();
            cbObjType.ItemsSource = new Classes.RPriorities();
            //ETPro.Classes.RPriorities rPriorities = 
            //cbObjType.ItemsSource = rPriorities;
          
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
