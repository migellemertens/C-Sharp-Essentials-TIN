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

namespace Exercise05
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

        private double _minDepth;
        private double _maxDepth;
        //private Polygon _pool;

        private void Window_Initialized(object sender, EventArgs e)
        {
            minDepthSlider.Minimum = 1;
            minDepthSlider.Maximum = 3;

            maxDepthSlider.Minimum = 1;
            maxDepthSlider.Maximum = 8;

            shallowMinLabel.Content = $"{minDepthSlider.Minimum}";
            shallowMaxLabel.Content = $"{minDepthSlider.Maximum}";
            deepMinLabel.Content = $"{maxDepthSlider.Minimum}";
            deepMaxLabel.Content = $"{maxDepthSlider.Maximum}";

            chosenMinDepth.Content = $"{minDepthSlider.Value}";
            chosenMaxDepth.Content = $"{maxDepthSlider.Value}";

            //DrawPool();
        }

        private void minDepthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _minDepth = minDepthSlider.Value;
            chosenMinDepth.Content = $"{_minDepth}";
            UpdatePool();
        }

        private void maxDepthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _maxDepth = maxDepthSlider.Value;
            chosenMaxDepth.Content = $"{_maxDepth}";
            UpdatePool();
        }

        private void DrawPool(double sliderMin, double sliderMax)
        {
            paperCanvas.Children.Clear();
            int x = 10;
            int y = 10;
            int width = 50;
            double slidermin = sliderMin * 4;
            double slidermax = sliderMax * 4;

            Polygon pool = new Polygon()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 1,
                Fill = new SolidColorBrush(Colors.LightSeaGreen),
            };

            Point point1 = new Point(x,y);
            Point point2 = new Point((x + width),10);
            Point point3 = new Point((x + width),(y + (slidermin * 4)));
            Point point4 = new Point(x,(y + (slidermax * 4)));
            

            PointCollection newPool = new PointCollection();
            newPool.Add(point1);
            newPool.Add(point2);
            newPool.Add(point3);
            newPool.Add(point4);
            pool.Points = newPool;

            paperCanvas.Children.Add(pool);
        }

        private void UpdatePool()
        {
            DrawPool(minDepthSlider.Value, maxDepthSlider.Value);
        }
        
    }
}
