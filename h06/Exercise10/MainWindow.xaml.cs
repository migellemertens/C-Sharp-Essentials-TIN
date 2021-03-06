using System;
using System.Windows;
using System.Windows.Threading;

namespace Exercise10
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timeLimit = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            timeLimit.Interval = TimeSpan.FromMilliseconds(1000);
            timeLimit.Tick += timeLimit_Tick;
            timeLimit.Start();

            timeLimitProgressBar.Value = 0;
            timeLimitProgressBar.Maximum = 5;
        }

        private void timeLimit_Tick(object sender, EventArgs e)
        {
            if(timeLimitProgressBar.Value == 5)
            {
                timeLimit.Stop();
                MessageBox.Show("U hebt slechts 5 seconden om in te loggen.", "Tijd verstreken", MessageBoxButton.OK, MessageBoxImage.Error);
                okButton.IsEnabled = false;
            }
            else
            {
                timeLimitProgressBar.Value++;
            }
            
        }
    }
}
