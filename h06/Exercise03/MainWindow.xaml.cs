using System;
using System.Windows;

namespace Exercise03
{
    
    public partial class MainWindow : Window
    {
        private Random randomNumber = new Random();
        private int _sum = 0;
        private double _average = 0;
        private int _counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateNumberButton_Click(object sender, RoutedEventArgs e)
        {
            int generatedNumber = randomNumber.Next(200, 401);

            _sum += generatedNumber;
            _counter++;
            _average = (double)_sum / _counter;

            randomTextBox.Text = $"{generatedNumber}";
            sumTextBox.Text = $"{_sum}";
            averageTextBox.Text = $"{_average}";
        }
    }
}
