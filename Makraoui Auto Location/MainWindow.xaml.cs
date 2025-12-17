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
            MainContent.Content = new CarsView();
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

