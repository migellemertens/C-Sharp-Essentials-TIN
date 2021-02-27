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

namespace Exercise02
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

        private void showNamesButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            ShowNames(firstName, lastName);
        }

        private void ShowNames(string firstName, string lastName)
        {
            MessageBox.Show($"First name: {firstName}", "First Name", MessageBoxButton.OK, MessageBoxImage.Information);
            MessageBox.Show($"Last name: {lastName}", "Last Name", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
