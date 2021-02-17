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

namespace Toepassing_3._3
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            Brush black = new SolidColorBrush(Colors.Black);

            Rectangle house = new Rectangle()
            {
                Width = 250,
                Height = 150,
                Stroke = black,
                StrokeThickness = 2,
                Margin = new Thickness(70, 80, 0, 0)
            };

            paperCanvas.Children.Add(house);

            Line line1 = new Line()
            {
                X1 = 70,
                Y1 = 80,
                X2 = 205,
                Y2 = 10,
                StrokeThickness = 2,
                Stroke = black
            };

            paperCanvas.Children.Add(line1);

            Line line2 = new Line()
            {
                X1 = 320,
                Y1 = 80,
                X2 = 205,
                Y2 = 10,
                StrokeThickness = 2,
                Stroke = black
            };

            paperCanvas.Children.Add(line2);

        }
    }
}
