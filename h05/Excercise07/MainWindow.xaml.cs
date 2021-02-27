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

namespace Excercise07
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brushToUse = new SolidColorBrush(Colors.Black);

            DrawStreet(paperCanvas, brushToUse, 10, 20, 40, 50);
        }

        private void DrawStreet(Canvas drawingArea, SolidColorBrush brushToUse, double topRoofX, double topRoofY, double width, double height)
        {
            DrawHouse(drawingArea, brushToUse, topRoofX, topRoofY, width, height);
            DrawHouse(drawingArea, brushToUse, topRoofX + (width + 20), topRoofY, width * 0.8, height * 0.8);
            DrawHouse(drawingArea, brushToUse, topRoofX + (width * 2 + 40), topRoofY, width * 0.6, height * 0.6);
            DrawHouse(drawingArea, brushToUse, topRoofX + (width * 3 + 60), topRoofY, width * 0.4, height * 0.4);
        }
        private void DrawHouse(Canvas drawingArea,
                               SolidColorBrush brushToUse,
                               double topRoofX,
                               double topRoofY,
                               double width,
                               double height)
        {
            DrawTriangle(drawingArea, brushToUse, topRoofX, topRoofY, width, height);
            DrawRectangle(drawingArea, brushToUse, topRoofX, topRoofY + height, width, height);
        }

        private void DrawTriangle(Canvas drawingArea,
                                  SolidColorBrush brushToUse,
                                  double xPlace,
                                  double yPlace,
                                  double width,
                                  double height)
        {
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace + height, xPlace + width, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace + width, yPlace + height);
        }

        private void DrawLine(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double startX, double startY,
                              double endX, double endY)
        {
            Line line = new Line();
            line.X1 = startX; line.X2 = endX;
            line.Y1 = startY; line.Y2 = endY;
            line.Stroke = brushToUse;
            line.StrokeThickness = 1;
            drawingArea.Children.Add(line);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPos,
                                   double yPos,
                                   double width,
                                   double height)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Margin = new Thickness(xPos, yPos, 0, 0);
            rectangle.Stroke = brushToUse;
            drawingArea.Children.Add(rectangle);
        }
    }
}
