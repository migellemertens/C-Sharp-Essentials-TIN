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

namespace Exercise04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SolidColorBrush brush = new SolidColorBrush(Colors.Black);
        public MainWindow()
        {
            InitializeComponent();
            DrawRectangle();
        }

        private void DrawRectangle()
        {
            for (int rij = 1; rij <= 6; rij++)
            {
                for (int kolom = 1; kolom <= rij; kolom++)
                {
                    Rectangle rect = new Rectangle
                    {
                        Stroke = brush,
                        Margin = new Thickness(kolom * 25, rij * 25, 0, 0),
                        Width = 20,
                        Height = 20
                    };
                    
                    paperCanvas.Children.Add(rect);

                }
            }

        }
    }
}
