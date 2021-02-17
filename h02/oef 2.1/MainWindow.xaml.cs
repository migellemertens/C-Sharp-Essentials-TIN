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

namespace oef_2._1
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

        private void aButton_Click(object sender, RoutedEventArgs e)
        {
            aLabel.Content = "Ja";
            bLabel.Content = "Ja";
            cLabel.Content = "Ja";
        }

        private void bButton_Click(object sender, RoutedEventArgs e)
        {
            aButton.Content = "Nee";
            bButton.Content = "Nee";
            cButton.Content = "Nee";
        }

        private void cButton_Click(object sender, RoutedEventArgs e)
        {
            aLabel.Content = "A";
            bLabel.Content = "B";
            cLabel.Content = "C";
        }
    }
}
