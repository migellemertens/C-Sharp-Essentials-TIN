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

namespace Exercise20
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int hours = Convert.ToInt32(hoursTextBox.Text);
            int minutes = Convert.ToInt32(minutesTextBox.Text);
            int seconds = Convert.ToInt32(secondsTextBox.Text);

            int numberOfSeconds = GetTimeInSeconds(hours, minutes, seconds);

            resultLabel.Content = numberOfSeconds.ToString();
        }

        private int GetTimeInSeconds(int hours, int minutes, int seconds)
        {
            return (hours * 60 * 60) + (minutes * 60) + seconds;
        }

        private void calculate2Button_Click(object sender, RoutedEventArgs e)
        {
            int minutes = Convert.ToInt32(minutesTextBox.Text);
            int seconds = Convert.ToInt32(secondsTextBox.Text);

            int numberOfSeconds = GetTimeInSeconds(minutes, seconds);

            resultLabel.Content = numberOfSeconds.ToString();
        }

        private int GetTimeInSeconds(int minutes, int seconds)
        {
            return (minutes * 60) + seconds;
        }
    }
}
