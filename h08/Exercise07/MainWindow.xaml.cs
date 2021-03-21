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

namespace Exercise07
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

        private void tekenButton_Click(object sender, RoutedEventArgs e)
        {
            int aantal = Convert.ToInt32(inputTextBox.Text);
            outputTextBlock.Text = "";

            for (int rij = 1; rij <= aantal; rij++)
            {
                outputTextBlock.Text += "\t";
                outputTextBlock.Text += Convert.ToString(rij);
            }

            outputTextBlock.Text += "\n";
            outputTextBlock.Text += "\n";

            for (int rij = 1; rij <= aantal; rij++)
            {
                outputTextBlock.Text += Convert.ToString(rij);
                for (int kolom = 1; kolom <= aantal; kolom++)
                {
                    outputTextBlock.Text += "\t";
                    outputTextBlock.Text += Convert.ToString(rij * kolom);
                }
                outputTextBlock.Text += "\n";
            }
        }
    }
}
