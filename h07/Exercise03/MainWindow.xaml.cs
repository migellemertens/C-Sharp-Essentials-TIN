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

namespace Exercise03
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
            int age = Convert.ToInt32(ageTextBox.Text);
            CalculateTicketPrice(age);
        }

        private void CalculateTicketPrice(int age)
        {
            if(age < 5)
            {
                MessageBox.Show("Free!");
            }
            else if(age >= 5 && age <= 12)
            {
                MessageBox.Show("Half price!");
            }
             else if(age >= 13 && age <= 54)
            {
                MessageBox.Show("Regular price");
            }
            else
            {
                MessageBox.Show("Free!");
            }
        }
    }
}
