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

namespace Exercise18
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int seconds1 = Convert.ToInt32(seconds1TextBox.Text);
            int seconds2 = Convert.ToInt32(seconds2TextBox.Text);

            CalculateTimeDifferenceInHoursMinutesSeconds(seconds1, seconds2);
        }

        private void CalculateTimeDifferenceInHoursMinutesSeconds(int seconds1, int seconds2)
        {
            int remainingSeconds;

            // checks which seconds to subtract
            if(seconds2 > seconds1)
            {
                remainingSeconds = seconds2 - seconds1;
            }
            else
            {
                remainingSeconds = seconds1 - seconds2;
            }

            // calls the Convert method
            ConvertSecondsToHoursMinutesSeconds(remainingSeconds, out int hours, out int minutes, out int seconds);

            // show result in label
            resultLabel.Content = $"Time Difference = {hours}:{minutes}:{seconds}";
        }

        private void ConvertSecondsToHoursMinutesSeconds(int totalAmountOfSeconds, out int hours, out int minutes, out int seconds)
        {
            hours = totalAmountOfSeconds / 3600;
            minutes = (totalAmountOfSeconds % 3600) / 60;
            seconds = totalAmountOfSeconds % 60;
        }
    }
}
