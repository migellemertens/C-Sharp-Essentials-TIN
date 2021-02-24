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


namespace Toepassing_5._5
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

        private void drawShapeButton_Click(object sender, RoutedEventArgs e)
        {
            int x1 = Convert.ToInt32(x1TextBox.Text);
            int y1 = Convert.ToInt32(y1TextBox.Text);
            int x2 = Convert.ToInt32(x2TextBox.Text);
            int y2 = Convert.ToInt32(y2TextBox.Text);
            int x3 = Convert.ToInt32(x3TextBox.Text);
            int y3 = Convert.ToInt32(y3TextBox.Text);

            DrawTriangle(drawAreaCanvas, x1, y1, x2, y2, x3, y3);
        }

        private void DrawTriangle(Canvas drawArea, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Polygon triangle = new Polygon()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                Fill = new SolidColorBrush(Colors.LightSeaGreen),
                StrokeThickness = 2,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center,
     
            };

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x3, y3);

            PointCollection trianglePointCollection = new PointCollection();
            trianglePointCollection.Add(point1);
            trianglePointCollection.Add(point2);
            trianglePointCollection.Add(point3);
            triangle.Points = trianglePointCollection;

            drawArea.Children.Add(triangle);
        }

        
    }
}
