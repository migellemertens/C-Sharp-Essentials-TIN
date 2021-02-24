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

namespace Toepassing_5._6
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
            int width = 50;
            int height = 50;
            int marginLeft = 20;

            

            DrawStreet(width, height, marginLeft);
        }
        private void DrawStreet(int width, int height, int marginLeft)
        {
            DrawRectangle(width, height, marginLeft);  
        }

        private void DrawRectangle(int width, int height, int marginLeft)
        {
            Rectangle house = new Rectangle()
            {
                Width = width,
                Height = height,
                Margin = new Thickness(marginLeft, 100, 0, 0),
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 2
            };

            drawAreaCanvas.Children.Add(house);
        }


    }
}
