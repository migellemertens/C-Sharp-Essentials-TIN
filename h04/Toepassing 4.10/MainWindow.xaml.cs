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

namespace Toepassing_4._10
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
            double b = Convert.ToDouble(startingBalanceTextBox.Text);
            int n = Convert.ToInt32(amountOfYearsTextBox.Text);
            double r = Convert.ToDouble(yearlyInterestTextBox.Text);

            double finalBalance = 0;
            
            for(int i = n; i > 0; i--)
            {
                finalBalance = b * (1 + (r / 100.0));
                b = finalBalance;
            }


            finalBalanceResultLabel.Content = $"Final Balance: {finalBalance:c}";
        }
    }
}
