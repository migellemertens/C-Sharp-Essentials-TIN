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

namespace Toepassing_5._3
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
            double yearlySalary = Convert.ToDouble(yearlySalaryTextBox.Text);
            int workingYears = Convert.ToInt32(workingYearsTextBox.Text);

            ShowSalary(yearlySalary, workingYears);
        }

        private void ShowSalary(double yearlySalary, int workingYears)
        {
            MessageBox.Show($"Yearly salary: {yearlySalary * workingYears:c}", "Yearly Salary", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
