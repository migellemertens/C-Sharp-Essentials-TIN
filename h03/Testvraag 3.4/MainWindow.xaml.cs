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

namespace Testvraag_3._4
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
            Line line1 = new Line()
            {
                X1 = 10,
                Y1 = 10,
                X2 = 64,
                Y2 = 10,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 4

            };

            paperCanvas.Children.Add(line1);

            Line line2 = new Line()
            {
                X1 = 38,
                Y1 = 10,
                X2 = 38,
                Y2 = 60,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 4
            };

            paperCanvas.Children.Add(line2);
        }
    }
}
