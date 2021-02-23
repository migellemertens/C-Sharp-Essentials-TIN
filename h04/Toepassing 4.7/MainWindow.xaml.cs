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

namespace Toepassing_4._7
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int totalNumberofSeconds = Convert.ToInt32(numberOfSecondsTextBox.Text);

            int hours = totalNumberofSeconds / 3600;
            int minutes = (totalNumberofSeconds % 3600) / 60;
            int seconds = totalNumberofSeconds % 60;

            resultLabel.Content = $"H: {hours} M: {minutes} S: {seconds}";

        }
    }
}
