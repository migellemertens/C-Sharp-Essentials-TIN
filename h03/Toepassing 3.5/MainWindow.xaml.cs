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

namespace Toepassing_3._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Brush white = new SolidColorBrush(Colors.White);
            Brush red = new SolidColorBrush(Colors.Red);

            DrawEllipse(400, 0, 0, white);
            DrawEllipse(300, 50, 50, red);
            DrawEllipse(200, 100, 100, white);
            DrawEllipse(100, 150, 150, red);
            DrawEllipse(70, 165, 165, white);
            DrawEllipse(40, 180, 180, red);
        }

        private void DrawEllipse(int size, int mLeft, int mTop, Brush color)
        {
            Ellipse ellipse = new Ellipse()
            {
                Width = size,
                Height = size,
                Fill = color,
                Margin = new Thickness(mLeft, mTop, 0, 0)
            };

            paperCanvas.Children.Add(ellipse);
        }
    }
}
