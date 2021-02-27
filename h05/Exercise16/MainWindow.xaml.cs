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

namespace Exercise16
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

        private void getNumbersButton_Click(object sender, RoutedEventArgs e)
        {
            GetInput(out int a, out int b, out int c);

            resultTextBlock.Text = $"Number 1: {a}\nNumber 2: {b}\nNumber 3: {c}";
        }

        private void GetInput(out int a, out int b, out int c)
        {
            a = Convert.ToInt32(number1TextBox.Text);
            b = Convert.ToInt32(number2TextBox.Text);
            c = Convert.ToInt32(number3TextBox.Text);
        }
    }
}
