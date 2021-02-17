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

namespace Toepassing_3._6
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

        private void tekenButton_Click(object sender, RoutedEventArgs e)
        {
            Brush pink = new SolidColorBrush(Colors.Pink);
            Brush white = new SolidColorBrush(Colors.White);

            TekenCirkel(200, 200, 10, 10, pink);
            TekenCirkel(50, 50, 40, 40, white);
            TekenCirkel(50, 50, 130, 40, white);

            Line lijn = new Line()
            {
                X1 = 60,
                Y1 = 150,
                X2 = 160,
                Y2 = 150,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2
            };

            paperCanvas.Children.Add(lijn);
        }

        private void TekenCirkel(int width, int height, int mLeft, int mTop, Brush kleur)
        {
            Ellipse ellipse = new Ellipse()
            {
                Width = width,
                Height = height,
                Margin = new Thickness(mLeft, mTop, 0, 0),
                Fill = kleur
            };

            paperCanvas.Children.Add(ellipse);
        }
    }
}
