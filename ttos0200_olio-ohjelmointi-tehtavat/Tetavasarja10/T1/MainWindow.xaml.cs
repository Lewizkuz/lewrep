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

namespace T1
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

        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            int luku = int.Parse(CarCount.Text);
            luku++;
            CarCount.Text = luku.ToString();
        }

        private void TruckCount1_Click(object sender, RoutedEventArgs e)
        {
            int luku = int.Parse(TruckCount.Text);
            luku++;
            TruckCount.Text = luku.ToString();
        }
    }
}
