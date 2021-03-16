using System;
using System.Windows;
using System.Windows.Threading;

namespace DTDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        private int _count;
        
        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(250);
            _timer.Tick += UpdateLabelOnTick;
            _count = 0;
        }

        private void UpdateLabelOnTick(object sender, EventArgs e)
        {
            countLabel.Content = $"Counter: {_count}";
            _count++;
        }

        private void startResumeButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            _count = 0;
            countLabel.Content = $"Counter: {_count}";
        }
    }
}
