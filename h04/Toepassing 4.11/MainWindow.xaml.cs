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

namespace Toepassing_4._11
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
            resultLabel.Content = "";

            int number = Convert.ToInt32(numberTextBox.Text);
            int[] binaryNumber = new int[100];
            int counter = 0;
            
            while(number > 0)
            {
                binaryNumber[counter] = number % 2;
                number = number / 2;
                counter++;
            }

            for(int i = counter - 1; i >= 0; i--)
            {
                resultLabel.Content += $"{binaryNumber[i]}";
            }

            
        }
    }
}
