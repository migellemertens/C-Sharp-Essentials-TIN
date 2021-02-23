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

namespace Toepassing_4._4
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

        private void berekenGemiddeldeButton_Click(object sender, RoutedEventArgs e)
        {
            double outcomeStudent1 = 44;
            double outcomeStudent2 = 51;
            double average = (outcomeStudent1 + outcomeStudent2) / 2;

            MessageBox.Show($"The average of {outcomeStudent1} and {outcomeStudent2} = {average}");
        }
    }
}
