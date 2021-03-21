using System.Windows;
using System;

namespace Exercise14
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            if(manRadioButton.IsChecked == true)
            {
                if(tussen18en30RadioButton.IsChecked == true)
                {
                    MessageBox.Show("200 euro");
                }
                if(tussen30en45RadioButton.IsChecked == true)
                {
                    MessageBox.Show("150 euro");
                }
                if(tussen45en60RadioButton.IsChecked == true)
                {
                    MessageBox.Show("100 euro");
                }
                if(ouderdan60RadioButton.IsChecked == true)
                {
                    MessageBox.Show("250 euro");
                }
            }

            if (vrouwRadioButton.IsChecked == true)
            {
                if (tussen18en30RadioButton.IsChecked == true)
                {
                    MessageBox.Show("200 euro");
                }
                if (tussen30en45RadioButton.IsChecked == true)
                {
                    MessageBox.Show("150 euro");
                }
                if (tussen45en60RadioButton.IsChecked == true)
                {
                    MessageBox.Show("100 euro");
                }
                if (ouderdan60RadioButton.IsChecked == true)
                {
                    MessageBox.Show("250 euro");
                }
            }
        }
    }
}
