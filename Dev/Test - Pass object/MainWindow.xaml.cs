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

namespace Test___Pass_object
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
            DrawRectangle(50);
        }

        private void drawPassObjectButton_Click(object sender, RoutedEventArgs e)
        {
            DrawRectangle(paperCanvas, 100);
        }

        private void DrawRectangle(int size)
        {
            paperCanvas.Children.Clear();

            Rectangle rectangle = new Rectangle()
            {
                Width = size,
                Height = size,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2,
                Margin = new Thickness(10,10,0,0)
            };

            paperCanvas.Children.Add(rectangle);
        }

        private void DrawRectangle(Canvas drawingArea, int size)
        {
            drawingArea.Children.Clear();

            Rectangle rectangle = new Rectangle()
            {
                Width = size,
                Height = size,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2,
                Margin = new Thickness(10, 10, 0, 0)
            };

            drawingArea.Children.Add(rectangle);
        }
    }
}
