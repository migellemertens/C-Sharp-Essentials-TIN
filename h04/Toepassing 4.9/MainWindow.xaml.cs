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

namespace Toepassing_4._9
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

        private void calculateChangeButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Text = "";
            int amountOfCents = Convert.ToInt32(amountOfCentsTextBox.Text);
            int itemPrice = 45;
            int rest = amountOfCents - itemPrice;


            int euro = rest / 100;
            rest = rest % 100;
            resultTextBlock.Text += $"Number of 1 euro coins is: {euro}\n";

            int fiftyCents = rest / 50;
            rest = rest % 50;
            resultTextBlock.Text += $"Number of 50 cent coins is: {fiftyCents}\n";

            int twentyCents = rest / 20;
            rest = rest % 20;
            resultTextBlock.Text += $"Number of 20 cent coins is: {twentyCents}\n";

            int tenCents = rest / 10;
            rest = rest % 10;
            resultTextBlock.Text += $"Number of 10 cent coins is: {tenCents}\n";

            int fiveCents = rest / 5;
            rest = rest % 5;
            resultTextBlock.Text += $"Numer of 5 cent coins is : {fiveCents}\n";

            int twoCents = rest / 2;
            rest = rest % 2;
            resultTextBlock.Text += $"Numer of 2 cent coins is : {twoCents}\n";

            int oneCents = rest;
            resultTextBlock.Text += $"Number of 1 cent coints is: {oneCents}\n";

        }
    }
}
