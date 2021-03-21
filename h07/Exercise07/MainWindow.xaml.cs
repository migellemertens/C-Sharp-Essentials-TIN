using System;
using System.Windows;
using System.Windows.Controls;

namespace Exercise07
{
    public partial class MainWindow : Window
    {
        private string _previousOperator = "";
        private int _previousNumber = 0;
        private bool _previousActivatedOperator = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
            if (displayTextBock.Text.Equals("0"))
            {
                displayTextBock.Text = displayTextBock.Text.Substring(1);
            }
            if (_previousActivatedOperator)
            {
                displayTextBock.Text = "";
            }

            displayTextBock.Text += ((Button)sender).Content;
            _previousActivatedOperator = false;
        }
        
        private void operatorButton_Click(object sender, RoutedEventArgs e)
        {
            if (_previousOperator == "")
            {
                _previousOperator = Convert.ToString(((Button)sender).Content);
                _previousNumber = Convert.ToInt32(displayTextBock.Text);
            }
            else
            {
                switch (_previousOperator)
                {
                    case "+":
                        displayTextBock.Text = Convert.ToString(_previousNumber + Convert.ToInt32(displayTextBock.Text));
                        _previousOperator = Convert.ToString(((Button)sender).Content);
                        _previousNumber = Convert.ToInt32(displayTextBock.Text);
                        break;
                    case "-":
                        displayTextBock.Text = Convert.ToString(_previousNumber - Convert.ToInt32(displayTextBock.Text));
                        _previousOperator = Convert.ToString(((Button)sender).Content);
                        _previousNumber = Convert.ToInt32(displayTextBock.Text);
                        break;
                }
            }
            if(Convert.ToString(((Button)sender).Content) == "=")
            {
                _previousOperator = "";
                _previousNumber = 0;
                _previousActivatedOperator = false;
            }
            _previousActivatedOperator = true;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            _previousOperator = "";
            _previousNumber = 0;
            displayTextBock.Text = "0";
            _previousActivatedOperator = false;
        }
    }
}
