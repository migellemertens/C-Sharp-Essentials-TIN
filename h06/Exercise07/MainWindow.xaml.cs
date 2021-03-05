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

namespace Exercise07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse _ellipse;

        public MainWindow()
        {
            InitializeComponent();
            DrawEllipse();

            horizontalSlider.Minimum = 0;
            horizontalSlider.Maximum = 50;

            verticalSlider.Minimum = 0;
            verticalSlider.Maximum = 50;

            sizeSlider.Minimum = 0;
            sizeSlider.Maximum = 275;
            sizeSlider.Value = 200;
        }

        private void DrawEllipse()
        {
            _ellipse = new Ellipse()
            {
                Width = 200,
                Height = 200,
                Fill = new SolidColorBrush(Colors.LightSeaGreen),
                Margin = new Thickness(0, 0, 0, 0)
            };

            paperCanvas.Children.Add(_ellipse);
        }

        private void DrawEllipse(int marginLeft, int marginTop)
        {
            Ellipse point = new Ellipse()
            {
                Width = 4,
                Height = 4,
                Fill = new SolidColorBrush(Colors.Black),
                Margin = new Thickness(marginLeft, marginTop, 0, 0)
            };

            paperCanvas.Children.Add(point);
        }

        private void horizontalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateEllipse();
        }

        private void verticalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateEllipse();
        }

        private void UpdateEllipse()
        {
            _ellipse.Margin = new Thickness(horizontalSlider.Value, verticalSlider.Value, 0, 0);
            _ellipse.Width = sizeSlider.Value;
            _ellipse.Height = sizeSlider.Value;
        }

        private void sizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateEllipse();
        }

        private void DrawThreeRandomPoints()
        {
            Random r = new Random();

            for(int i = 0; i < 3; i++)
            {
                int marginLeft = r.Next(0, 275);
                int marginRight = r.Next(0, 275);
                DrawEllipse(marginLeft, marginRight);
            }
        }

        private void newGameButton_Click(object sender, RoutedEventArgs e)
        {
            DrawThreeRandomPoints();
        }
    }
}
