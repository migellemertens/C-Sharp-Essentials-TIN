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

namespace Exercise17
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

            GetInput(out int hours1, out int minutes1, out int seconds1, out int hours2, out int minutes2, out int seconds2);

            int difference = CalculateTimeDifferenceInSeconds(hours1, minutes1, seconds1, hours2, minutes2, seconds2);

            resultLabel.Content = difference.ToString();
        }

        private void GetInput(out int a, out int b, out int c, out int d, out int e, out int f)
        {
            a = Convert.ToInt32(hoursTextBox.Text);
            b = Convert.ToInt32(minutesTextBox.Text);
            c = Convert.ToInt32(secondsTextBox.Text);
            d = Convert.ToInt32(hours2TextBox.Text);
            e = Convert.ToInt32(minutes2TextBox.Text);
            f = Convert.ToInt32(seconds2TextBox.Text);
        }

        private int CalculateTimeDifferenceInSeconds(int h, int m, int s, int h2, int m2, int s2)
        {
            int returnValue;

            int seconds1 = GetTimeInSeconds(h, m, s);
            int seconds2 = GetTimeInSeconds(h2, m2, s2);

            if(seconds1 > seconds2)
            {
                returnValue = seconds1 - seconds2;
            }
            else
            {
                returnValue = seconds2 - seconds1;
            }

            return returnValue;

        }
        private int GetTimeInSeconds(int hours, int minutes, int seconds)
        {
            return (hours * 60 * 60) + (minutes * 60) + seconds;
        }
    }
}
