using System.Windows;
using System;

namespace Exercise13
{
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double btw = 0.21;
            double net = Convert.ToDouble(netPriceTextbox.Text);

            if(loweredTariffCheckBox.IsChecked == true)
            {
                btw = 0.06;
            }

            btwTextBox.Text = Convert.ToString(btw * net);
            totalTextBox.Text = Convert.ToString(net * (1 + btw));
        }
    }
}
