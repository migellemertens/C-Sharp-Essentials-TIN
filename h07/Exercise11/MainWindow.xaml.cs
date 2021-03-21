using System;
using System.Windows;

namespace Exercise11
{
    public partial class MainWindow : Window
    {
        private Random _randomNumber1 = new Random(5000);
        private Random _randomNumber2 = new Random(5000);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void randomNumber1Button_Click(object sender, RoutedEventArgs e)
        {
            randomNumber1Label.Content = Convert.ToString(_randomNumber1.Next());
            while (randomNumber1Label.Content.Equals(randomNumber2Label.Content))
            {
                randomNumber1Label.Content = Convert.ToString(_randomNumber1.Next());
            }
        }

        private void randomNumber2Button_Click(object sender, RoutedEventArgs e)
        {
            randomNumber2Label.Content = Convert.ToString(_randomNumber2.Next());
            while (randomNumber2Label.Content.Equals(randomNumber1Label.Content))
            {
                randomNumber2Label.Content = Convert.ToString(_randomNumber2.Next());
            }
        }
    }
}
