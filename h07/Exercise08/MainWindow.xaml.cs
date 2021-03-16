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
using System.Windows.Threading;

namespace Exercise08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle _elevator;
        private DispatcherTimer timer = new DispatcherTimer();
        private int _floor = 0;
        private int _topMargin = 320;
        private bool _up = false;
        public MainWindow()
        {
            InitializeComponent();
            DrawRectangle();
            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += RunTimer;
        }

        private void RunTimer(object sender, EventArgs e)
        {
            if (_up) 
            { 
                if(_topMargin == 0)
                {
                    MessageBox.Show("Elevator is already on top floor");
                }
                else
                {
                    _topMargin -= 40;
                }
            }
        }

        private void DrawRectangle()
        {
            _elevator = new Rectangle()
            {
                Width = 40,
                Height = 40,
                Margin = new Thickness(100, _topMargin, 0, 0),
                Fill = new SolidColorBrush(Colors.MediumAquamarine)
            };

            paperCanvas.Children.Add(_elevator);
        }

        private void upButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            _up = true;
        }

        private void UpdateRectangle(int movementSize)
        {

        }
    }
}
