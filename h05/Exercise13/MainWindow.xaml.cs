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

namespace Exercise13
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

        private void incrementButton_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(numberTextBox.Text);

            int increment = Increment(number);

            resultLabel.Content = increment.ToString();
        }

        private int Increment(int number)
        {
            return number + 1;
        }
    }
}
