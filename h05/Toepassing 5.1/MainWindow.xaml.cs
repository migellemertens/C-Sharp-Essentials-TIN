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

namespace Toepassing_5._01
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

        private void showMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;

            ShowName(name);
        }

        private void ShowName(string name)
        {
            MessageBox.Show($"Hello {name}", "Show Name", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
