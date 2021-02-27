using System;
using System.Windows;

namespace Exercise14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int decimalNumber = Convert.ToInt32(numberTextBox.Text);
            string binaryNumber = ConvertNumberToBinary(decimalNumber);
            resultLabel.Content = binaryNumber;

        }

        private string ConvertNumberToBinary(int decimalNumber)
        {
            string returnValue = "";
            int[] binaryNumber = new int[100];
            int counter = 0;

            while (decimalNumber > 0)
            {
                binaryNumber[counter] = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                counter++;
            }

            for (int i = counter - 1; i >= 0; i--)
            {
                returnValue += $"{binaryNumber[i]}";
            }

            return returnValue;
        }
    }
}
