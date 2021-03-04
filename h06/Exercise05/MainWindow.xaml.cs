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

namespace Exercise05
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

        private double _minDepth;
        private double _maxDepth;

        private void Window_Initialized(object sender, EventArgs e)
        {
            minDepthSlider.Minimum = 1;
            minDepthSlider.Maximum = 3;

            maxDepthSlider.Minimum = 1;
            maxDepthSlider.Maximum = 8;

            shallowMinLabel.Content = $"{minDepthSlider.Minimum}";
            shallowMaxLabel.Content = $"{minDepthSlider.Maximum}";
            deepMinLabel.Content = $"{maxDepthSlider.Minimum}";
            deepMaxLabel.Content = $"{maxDepthSlider.Maximum}";

            chosenMinDepth.Content = $"{minDepthSlider.Value}";
            chosenMaxDepth.Content = $"{maxDepthSlider.Value}";
        }

        private void minDepthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _minDepth = minDepthSlider.Value;
            chosenMinDepth.Content = $"{_minDepth}";
        }

        private void maxDepthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _maxDepth = maxDepthSlider.Value;
            chosenMaxDepth.Content = $"{_maxDepth}";
        }
        
    }
}
