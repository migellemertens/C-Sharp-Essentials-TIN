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

namespace Excercise04
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
            double xCentre = Convert.ToDouble(xCentreTextBox.Text);
            double yCentre = Convert.ToDouble(yCentreTextBox.Text);
            double radius = Convert.ToDouble(radiusTextBox.Text);

            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            DrawCircle(drawAreaCanvas, brush, xCentre, yCentre, radius);
        }

        private void DrawCircle(Canvas drawArea, SolidColorBrush brush, double xCentre, double yCentre, double radius)
        {
            // Draws circle with X-Y position, not from centre

            Ellipse ellipse = new Ellipse()
            {
                Width = radius * 2,
                Height = radius * 2,
                Margin = new Thickness(xCentre, yCentre, 0, 0),
                Stroke = brush,
                StrokeThickness = 2
            };

            drawArea.Children.Add(ellipse);
        }
    }
}
