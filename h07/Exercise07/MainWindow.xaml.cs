using System;
using System.Windows;
using System.Windows.Controls;

namespace Exercise07
{
    public partial class MainWindow : Window
    {
        private int _total = 0;
        private int _temp;
        private bool _clear = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (_clear)
            {
                resultTextBox.Clear();
                _clear = !_clear;
            }

            var clickedButton = (sender as Button).Content;

            resultTextBox.Text += clickedButton;
            
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            
            var clickedButton = (sender as Button).Content;

            _temp = Convert.ToInt32(resultTextBox.Text);
            switch (clickedButton.ToString())
            { 
                case "+":
                    _total += _temp;
                    resultTextBox.Text = _total.ToString();
                    _clear = true;
                    break;
                case "-":
                    _total -= _temp;
                    resultTextBox.Text = _total.ToString();
                    _clear = true;
                    break;
                case "=":
                    resultTextBox.Text = _total.ToString();
                    _clear = true;
                    break;
            }

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            _total = 0;
        }
    }
}
