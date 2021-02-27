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

namespace Exercise12
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double radius = Convert.ToDouble(radiusTextBox.Text);
            double height = Convert.ToDouble(heightTextBox.Text);

            double volume = CalculateVolume(radius, height);

            resultLabel.Content = $"{volume:F} cm³";
        }

        private double CalculateVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }
}
