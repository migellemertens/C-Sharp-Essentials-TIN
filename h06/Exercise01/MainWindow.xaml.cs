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

        private void setValuesButton_Click(object sender, RoutedEventArgs e)
        {
            horizontalSlider.Minimum = Convert.ToInt32(number1TextBox.Text);
            horizontalSlider.Maximum = Convert.ToInt32(number2TextBox.Text);

            minValueLabel.Content = horizontalSlider.Minimum;
            maxValueLabel.Content = horizontalSlider.Maximum;
        }

        private void horizontalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            currentValueLabel.Content = Convert.ToInt32(horizontalSlider.Value);
        }
    }
}
