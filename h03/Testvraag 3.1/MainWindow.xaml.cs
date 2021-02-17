﻿using System;
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

namespace Testvraag_3._1
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
            Ellipse cirkel = new Ellipse()
            {
                Width = 100,
                Height = 100,
                Margin = new Thickness(10, 10, 0, 0),
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 4,
                Fill = new SolidColorBrush(Colors.Red)
                
            };

            paperCanvas.Children.Add(cirkel);
        }
    }
}
