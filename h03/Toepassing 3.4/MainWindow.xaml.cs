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

namespace Toepassing_3._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DrawLine(10, 10, 10, 240);
            DrawLine(10, 240, 350, 240);
            DrawRectangle(30, 150, 25, -327);
            DrawRectangle(30, 175, 85, -302);
            DrawRectangle(30, 120, 145, -358);
            DrawRectangle(30, 130, 205, -348);
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            Line line = new Line()
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2
            };

            paperCanvas.Children.Add(line);
        }

        private void DrawRectangle(int width, int height, int left, int bottom)
        {

            Rectangle rectangle = new Rectangle()
            {
                Width = width,
                Height = height,
                Margin = new Thickness(left, 0, 0, bottom),
                Fill = new SolidColorBrush(Colors.Aqua)
            };

            paperCanvas.Children.Add(rectangle);
        }
    }
}
