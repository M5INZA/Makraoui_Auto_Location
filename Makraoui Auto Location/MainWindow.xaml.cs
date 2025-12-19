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
using Makraoui_Auto_Location.View;
using System.Windows.Media.Animation;

namespace Makraoui_Auto_Location
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new DashboardView();
        }

        private void MenuBorder_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimateMenu(220);
            btnDashboard.Content = "Dashboard 🏠";
            btnClients.Content = "Clients 👤";
            btnCars.Content = "Cars 🚗";
            btnContracts.Content = "Contracts 📝";
        }

        private void MenuBorder_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimateMenu(60);
            btnDashboard.Content = "🏠";
            btnClients.Content = "👤";
            btnCars.Content = "🚗";
            btnContracts.Content = "📝";
        }

        private void AnimateMenu(double toWidth)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                To = toWidth,
                Duration = TimeSpan.FromMilliseconds(20),
                EasingFunction = new CubicEase
                {
                    EasingMode = EasingMode.EaseOut
                }
            };

            MenuColumn.BeginAnimation(
                ColumnDefinition.WidthProperty,
                new GridLengthAnimation(animation));
        }
    }
}
namespace Makraoui_Auto_Location.Models
{
    public class Vehicle
    {
        public string Plate { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
    }
}

