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

namespace Exercise02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            number1Slider.Minimum = 0;
            number1Slider.Maximum = 200;
            number1Slider.Value = 0;

            number2Slider.Minimum = 0;
            number2Slider.Maximum = 200;
            number2Slider.Value = 0;

            number3Slider.Minimum = 0;
            number3Slider.Maximum = 200;
            number3Slider.Value = 0;
        }

        private void orderNumbersButton_Click(object sender, RoutedEventArgs e)
        {
            double number1 = number1Slider.Value;
            double number2 = number2Slider.Value;
            double number3 = number3Slider.Value;

            if (number1 > number2 && number1 > number3)
            {
                if (number2 > number3)
                {
                    resultLabel.Content = $"{number1:F} - {number2:F} - {number3:F}";
                }
                else
                {
                    resultLabel.Content = $"{number1:F} - {number3:F} - {number2:F}";
                }
            }
            if (number2 > number1 && number2 > number3)
            {
                if (number1 > number3)
                {
                    resultLabel.Content = $"{number2:F} - {number1:F} - {number3:F}";
                }
                else
                {
                    resultLabel.Content = $"{number2:F} - {number3:F} - {number1:F}";
                }
            }
            if (number3 > number1 && number3 > number2)
            {
                if (number1 > number2)
                {
                    resultLabel.Content = $"{number3:F} - {number1:F} - {number2:F}";
                }
                else
                {
                    resultLabel.Content = $"{number3:F} - {number2:F} - {number1:F}";
                }
            }
        }
    }
}
