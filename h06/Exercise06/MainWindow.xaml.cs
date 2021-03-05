using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Exercise06
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private Rectangle _secondsRectangle;
        private Rectangle _minutesRectangle;
        private int _secondsCounter = 0;
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += timer_Tick;
            timer.Start();

            DrawRectangle();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            _secondsCounter++;
            secondsLabel.Content = _secondsCounter;
            UpdateRectangle();
        }

        private void DrawRectangle()
        {
            _minutesRectangle = new Rectangle()
            {
                Width = 0,
                Height = 50,
                Margin = new Thickness(0, 40, 0, 0),
                Fill = new SolidColorBrush(Colors.LightSeaGreen)
            };

            paperCanvas.Children.Add(_minutesRectangle);

            _secondsRectangle = new Rectangle()
            {
                Width = 0,
                Height = 50,
                Margin = new Thickness(0, 120, 0, 0),
                Fill = new SolidColorBrush(Colors.LightSeaGreen)
            };

            paperCanvas.Children.Add(_secondsRectangle);
 
        }

        private void UpdateRectangle()
        {
            if(_secondsCounter == 3600)
            {
                _minutesRectangle.Width = 0;
                return;
            }

            if(_secondsCounter % 60 == 0)
            {
                _minutesRectangle.Width += 10;
                _secondsRectangle.Width = 0;
            }
            else
            {
                _secondsRectangle.Width += 10;
            }
   
        }
    }
}
