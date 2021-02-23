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

namespace Toepassing_4._8
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

        private void calculateSerialButton_Click(object sender, RoutedEventArgs e)
        {
            resultSerialLabel.Content = "";
            double r1 = Convert.ToDouble(r1TextBox.Text);
            double r2 = Convert.ToDouble(r2TextBox.Text);

            double serialResult = r1 + r2;

            resultSerialLabel.Content = $"Serial calculation: {serialResult:f}";
        }

        private void calculateParallelButton_Click(object sender, RoutedEventArgs e)
        {
            resultParallelLabel.Content = "";
            double r1 = Convert.ToDouble(r1TextBox.Text);
            double r2 = Convert.ToDouble(r2TextBox.Text);

            double parallelResult = (r1 * r2) / (r1 + r2);

            resultParallelLabel.Content = $"Parallel calculation: {parallelResult:f}";
        }
    }
}
