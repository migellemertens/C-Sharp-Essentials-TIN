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

namespace Exercise04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle _celciusRectangle;
        private Rectangle _fahrenheitRectangle;
        private double _fahrenheit;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            temperatureSlider.Minimum = 0;
            temperatureSlider.Maximum = 100;

            minTempLabel.Content = temperatureSlider.Minimum;
            maxTempLabel.Content = temperatureSlider.Maximum;

            DrawRectangle();
        }

        private void temperatureSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _fahrenheit = temperatureSlider.Value * 9 / 5 + 32;
            celciusLabel.Content = $"{temperatureSlider.Value:F}°";
            fahrenheitLabel.Content = $"{_fahrenheit:F}°";
            UpdateRectangle();
        }

        private void DrawRectangle()
        {
            _celciusRectangle = new Rectangle()
            {
                Width = temperatureSlider.Value,
                Height = 10,
                Fill = new SolidColorBrush(Colors.Aquamarine),
                Margin = new Thickness(0, 10, 0, 0)
            };
            paperCanvas.Children.Add(_celciusRectangle);

            _fahrenheitRectangle = new Rectangle()
            {
                Width = _fahrenheit,
                Height = 10,
                Fill = new SolidColorBrush(Colors.Aquamarine),
                Margin = new Thickness(0, 50, 0, 0)
            };
            paperCanvas.Children.Add(_fahrenheitRectangle);

        }

        private void UpdateRectangle()
        {
            _celciusRectangle.Width = temperatureSlider.Value;
            _fahrenheitRectangle.Width = _fahrenheit;
        }
    }
}
