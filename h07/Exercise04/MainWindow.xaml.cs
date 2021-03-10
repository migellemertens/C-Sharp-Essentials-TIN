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

namespace Exercise04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        private int[] _numbers = new int[3];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            rollDiceProgressBar.Value = 0;
            rollDiceProgressBar.Maximum = 3;

            _timer.Interval = TimeSpan.FromMilliseconds(1000);
            _timer.Tick += timeLimit_Tick;
            
        }

        private void timeLimit_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int counter = 0;
            while(counter < 2)
            {
                _numbers[counter] = r.Next(1, 7);
                rollDiceProgressBar.Value++;
                counter++;
            }
            _timer.Stop();
            CheckNumbers();

        }
        private void rollDiceButton_Click(object sender, RoutedEventArgs e)
        {
            rollDiceProgressBar.Value = 0;
            _timer.Start();
        }

        private void CheckNumbers() 
        {
            int number1 = _numbers[0];
            int number2 = _numbers[1];
            int number3 = _numbers[2];

            if (number1 == number2 && number1 == number3)
            {
                if (number1 == 6 && number2 == 6 && number3 == 6)
                {
                    MessageBox.Show("Winst 20 euro");
                }
                else
                {
                    MessageBox.Show("Winst: 10 euro");
                }
            }
            else
            {
                if (number1 == number2 || number2 == number3 || number3 == number1)
                {
                    MessageBox.Show("Winst: 5 euro");
                }
                else
                {
                    MessageBox.Show("Geen Winst!");
                }
            }
        }
    }
}
