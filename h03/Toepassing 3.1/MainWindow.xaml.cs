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

namespace Toepassing_3._1
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
            Brush zwart = new SolidColorBrush(Colors.Black);

            Line verticaleLijn = new Line()
            {
                Y1 = 10,
                X1 = 10,
                Y2 = 200,
                X2 = 10,
                Stroke = zwart,
                StrokeThickness = 3

            };

            paperCanvas.Children.Add(verticaleLijn);

            Line horizontaleLijn = new Line()
            {
                Y1 = 200,
                X1 = 10,
                Y2 = 200,
                X2 = 200,
                Stroke = zwart,
                StrokeThickness = 3

            };

            paperCanvas.Children.Add(horizontaleLijn);

            Line diagonaleLijn = new Line()
            {
                Y1 = 10,
                X1 = 10,
                Y2 = 200,
                X2 = 200,
                Stroke = zwart,
                StrokeThickness = 3

            };

            paperCanvas.Children.Add(diagonaleLijn);
        }
    }
}
