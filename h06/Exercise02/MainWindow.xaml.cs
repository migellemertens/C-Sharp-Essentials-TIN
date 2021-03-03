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

namespace Exercise02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _number = 1;
        public MainWindow()
        {
            InitializeComponent();
            resultLabel.Content = $"{_number}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _number++;
            resultLabel.Content = $"{_number}";
        }
    }
}
