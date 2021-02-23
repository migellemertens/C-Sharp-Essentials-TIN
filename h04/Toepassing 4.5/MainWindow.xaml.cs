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

namespace Toepassing_4._5
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
            double taxRate = 0.2;
            double salary = Convert.ToDouble(salaryTextBox.Text);

            double tax = salary * taxRate;
            double netIncome = salary - tax;

            taxesLabel.Content = $"Taxes to pay = {tax:c}";
            netIncomeLabel.Content = $"Net income = {netIncome:c}";
        }
    }
}
