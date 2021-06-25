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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ETPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MetroWindow_ContentRendered(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                Window window=null;
                string win = b.Content.ToString();
                switch (win)
                {
                    case "UserWindow":window = new UserWindow();break;
                    case "AddressWindow": window = new AddressWindow(); break;
                    case "ClientWindow": window = new ClientWindow(); break;
                    case "ClntOrderWindow": window = new ClntOrderWindow();break;
                    case "CommuWindow": window = new CommuWindow(); break;
                    case "DescWindow": window = new DescWindow(); break;
                    case "LincWindow": window = new LincWindow(); break;
                    case "DriverWindow": window = new DriverWindow(); break;
                    case "VehicleWindow": window = new VehicleWindow(); break;
                    case "PassengerWindow": window = new PassengerWindow(); break;
                    case "ReminderWindow": window = new ReminderWindow(); break;
                    case "DocWindow": window = new DocWindow(); break;
                    case "DiaryShuttleWindow": window = new DiaryShuttleWindow(); break;
                    case "DryShtlsPassengerWindow": window = new DryShtlsPassengerWindow(); break;
                    case "EventCategWindow": window = new EventCategWindow(); break;
                    case "EventWindow": window = new EventWindow(); break;
                }
                window?.ShowDialog();
            }
        }
    }
}
