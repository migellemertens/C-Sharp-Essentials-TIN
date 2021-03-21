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

namespace Image_update_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapImage _chosenImage = new BitmapImage();
        private Image _userImage = new Image();
        private Type _choice;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rockButton_Click(object sender, RoutedEventArgs e)
        {
            string choice = Type.ROCK.ToString().ToLower();
            SetImage(choice);
        }

        private void paperButton_Click(object sender, RoutedEventArgs e)
        {
            string choice = Type.PAPER.ToString().ToLower();
            SetImage(choice);
        }

        private void scissorButton_Click(object sender, RoutedEventArgs e)
        {
            string choice = Type.SCISSOR.ToString().ToLower();
            SetImage(choice);
        }

        public void SetImage(string choice)
        {
            _chosenImage.BeginInit();
            _chosenImage.UriSource = new Uri($"img\\{choice}.png", UriKind.RelativeOrAbsolute);
            _chosenImage.EndInit();

            ShowImage();
        }

        public void ShowImage()
        {
            _userImage.Source = _chosenImage;
            _userImage.Margin = new Thickness(0, 0, 0, 0);
            _userImage.Width = 200;
            _userImage.Height = 200;
            paperCanvas.Children.Add(_userImage);
        }
    }
}
