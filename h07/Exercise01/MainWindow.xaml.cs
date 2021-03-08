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

namespace Exercise01
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

        private void randomCardButton_Click(object sender, RoutedEventArgs e)
        {
            cardLabel.Content = "";

            string[] kaarttypes = { "Schoppen", "Harten", "Klaveren", "Koeken" };
            string[] kaartValue = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Boer", "Dame", "Heer", "Aas" };

            Random r = new Random();

            string cardType = kaarttypes[r.Next(0, kaarttypes.Length)];
            string cardValue = kaartValue[r.Next(0, kaartValue.Length)];

            cardLabel.Content = $"{cardType} {cardValue}";

        }
    }
}
