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

namespace Toepassing_4._2
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

        private void berekenOmtrektButton_Click(object sender, RoutedEventArgs e)
        {
            double straal = Convert.ToDouble(straalTextBox.Text);
            double omtrek = 2 * Math.PI * straal;

            //MessageBox.Show($"De omtrek van de cirkel is {omtrek:F} cm");
            omtrekLabel.Content = $"De omtrek van de cirkel is {omtrek:F} cm";
        }

        private void berekenOppervlakteButton_Click(object sender, RoutedEventArgs e)
        {
            double straal = Convert.ToDouble(straalTextBox.Text);
            double oppervlakte = Math.PI * Math.Pow(straal, 2);

            //MessageBox.Show($"De oppervlakte van de cirkel is {oppervlakte:F} cm²");
            oppervlakteLabel.Content = $"De oppervlakte van de cirkel is {oppervlakte:F} cm²";
        }

        private void berekenVolumeButton_Click(object sender, RoutedEventArgs e)
        {
            double straal = Convert.ToDouble(straalTextBox.Text);
            double volume = (4 * Math.PI / 3) * Math.Pow(straal, 3);

            //MessageBox.Show($"Het volume van de bol is {volume:F} cm³");
            volumeLabel.Content = $"Het volume van de bol is {volume:F} cm³";
        }
    }
}
