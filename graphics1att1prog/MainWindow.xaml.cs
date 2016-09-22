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

namespace graphics1att1prog
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawB_Click(object sender, RoutedEventArgs e)
        {
            draw();
        }

        private void draw()
        {
            Ellipse elH = new Ellipse();
            elH.Width = 80;
            elH.Height = 80;
            elH.VerticalAlignment = VerticalAlignment.Top;
            elH.HorizontalAlignment = HorizontalAlignment.Left;
            elH.Margin = new Thickness(70, 50, 0, 0);
            elH.Fill = Brushes.Cornsilk;
            elH.Stroke = Brushes.Bisque;
            elH.StrokeThickness = 2;
            canvas1.Children.Add(elH);

            Ellipse elEO = new Ellipse();
            elEO.Width = 30;
            elEO.Height = 30;
            elEO.VerticalAlignment = VerticalAlignment.Top;
            elEO.HorizontalAlignment = HorizontalAlignment.Left;
            elEO.Margin = new Thickness(90, 70, 0, 0);
            elEO.Fill = Brushes.White;
            elEO.Stroke = Brushes.Black;
            elEO.StrokeThickness = 1;
            canvas1.Children.Add(elEO);

            Ellipse elEI = new Ellipse();
            elEI.Width = 13;
            elEI.Height = 13;
            elEI.VerticalAlignment = VerticalAlignment.Top;
            elEI.HorizontalAlignment = HorizontalAlignment.Left;
            elEI.Margin = new Thickness(97, 78, 0, 0);
            elEI.Fill = Brushes.Black;
            elEI.Stroke = Brushes.Black;
            elEI.StrokeThickness = 1;
            canvas1.Children.Add(elEI);

            Ellipse elEB = new Ellipse();
            elEB.Width = 7;
            elEB.Height = 7;
            elEB.VerticalAlignment = VerticalAlignment.Top;
            elEB.HorizontalAlignment = HorizontalAlignment.Left;
            elEB.Margin = new Thickness(97, 78, 0, 0);
            elEB.Fill = Brushes.White;
            elEB.Stroke = Brushes.White;
            elEB.StrokeThickness = 1;
            canvas1.Children.Add(elEB);

            {   //elscallop
                Ellipse elscallop1 = new Ellipse();
                elscallop1.Width = 28;
                elscallop1.Height = 28;
                elscallop1.VerticalAlignment = VerticalAlignment.Top;
                elscallop1.HorizontalAlignment = HorizontalAlignment.Left;
                elscallop1.Margin = new Thickness(95, 23, 0, 0);
                elscallop1.Fill = Brushes.LightCoral;
                elscallop1.Stroke = Brushes.IndianRed;
                elscallop1.StrokeThickness = 1;
                canvas1.Children.Add(elscallop1);

                Ellipse elscallop2 = new Ellipse();
                elscallop2.Width = 28;
                elscallop2.Height = 28;
                elscallop2.VerticalAlignment = VerticalAlignment.Top;
                elscallop2.HorizontalAlignment = HorizontalAlignment.Left;
                elscallop2.Margin = new Thickness(122, 30, 0, 0);
                elscallop2.Fill = Brushes.LightCoral;
                elscallop2.Stroke = Brushes.IndianRed;
                elscallop2.StrokeThickness = 1;
                canvas1.Children.Add(elscallop2);

                Ellipse elscallop3 = new Ellipse();
                elscallop3.Width = 28;
                elscallop3.Height = 28;
                elscallop3.VerticalAlignment = VerticalAlignment.Top;
                elscallop3.HorizontalAlignment = HorizontalAlignment.Left;
                elscallop3.Margin = new Thickness(142, 48, 0, 0);
                elscallop3.Fill = Brushes.LightCoral;
                elscallop3.Stroke = Brushes.IndianRed;
                elscallop3.StrokeThickness = 1;
                canvas1.Children.Add(elscallop3);
            }

            Polygon beak = new Polygon();
            beak.Points = new PointCollection();
            beak.Points.Add(new Point(70, 98));
            beak.Points.Add(new Point(50, 114));
            beak.Points.Add(new Point(65, 90));
            beak.Points.Add(new Point(50, 66));
            beak.Points.Add(new Point(70, 82));
            beak.Stroke = Brushes.IndianRed;
            beak.Fill = Brushes.LightCoral;
            canvas1.Children.Add(beak);

            Rectangle body = new Rectangle();
            body.Width = 70;
            body.Height = 70;
            body.Fill = Brushes.Cornsilk;
            body.Stroke = Brushes.Bisque;
            body.Margin = new Thickness(62, 127, 0, 0);
            body.StrokeThickness = 3;
            body.LayoutTransform = new RotateTransform(45);
            canvas1.Children.Add(body);


            Polygon legs = new Polygon();
            legs.Points = new PointCollection();
            legs.Points.Add(new Point(112, 226));
            legs.Points.Add(new Point(97, 238));
            legs.Points.Add(new Point(127, 238));
            legs.Stroke = Brushes.IndianRed;
            legs.Fill = Brushes.LightCoral;
            legs.StrokeThickness = 2;
            canvas1.Children.Add(legs);

            {   //tail

                //1
                Ellipse tail1 = new Ellipse();
                tail1.Width = 80;
                tail1.Height = 80;
                tail1.VerticalAlignment = VerticalAlignment.Top;
                tail1.HorizontalAlignment = HorizontalAlignment.Left;
                tail1.Margin = new Thickness(150, 110, 0, 0);
                tail1.Fill = Brushes.PaleGreen;
                tail1.Stroke = Brushes.MediumSeaGreen;
                tail1.StrokeDashArray = new DoubleCollection();
                tail1.StrokeThickness = 1;
                canvas1.Children.Add(tail1);

                Polygon tail1P = new Polygon();
                tail1P.Points = new PointCollection();
                tail1P.Points.Add(new Point(160, 177));
                tail1P.Points.Add(new Point(220, 125));
                tail1P.Points.Add(new Point(300, 177));
                tail1P.Points.Add(new Point(220, 229));
                tail1P.Stroke = Brushes.White;
                tail1P.Fill = Brushes.White;
                canvas1.Children.Add(tail1P);

                Line tail1L = new Line();
                tail1L.X1 = 160;
                tail1L.Y1 = 177;
                tail1L.X2 = 220;
                tail1L.Y2 = 125;
                tail1.StrokeThickness = 1;
                tail1L.Stroke = Brushes.MediumSeaGreen;
                canvas1.Children.Add(tail1L);

                //2
                Ellipse tail2 = new Ellipse();
                tail2.Width = 80;
                tail2.Height = 80;
                tail2.VerticalAlignment = VerticalAlignment.Top;
                tail2.HorizontalAlignment = HorizontalAlignment.Left;
                tail2.Margin = new Thickness(160, 130, 0, 0);
                tail2.Fill = Brushes.PowderBlue;
                tail2.Stroke = Brushes.DeepSkyBlue;
                tail2.StrokeThickness = 1;
                canvas1.Children.Add(tail2);

                Polygon tail2P = new Polygon();
                tail2P.Points = new PointCollection();
                tail2P.Points.Add(new Point(160, 177));
                tail2P.Points.Add(new Point(238, 157));
                tail2P.Points.Add(new Point(300, 190));
                tail2P.Points.Add(new Point(160, 229));
                tail2P.Stroke = Brushes.White;
                tail2P.Fill = Brushes.White;
                canvas1.Children.Add(tail2P);

                Line tail2L = new Line();
                tail2L.X1 = 160;
                tail2L.Y1 = 177;
                tail2L.X2 = 238;
                tail2L.Y2 = 157;
                tail2.StrokeThickness = 1;
                tail2L.Stroke = Brushes.DeepSkyBlue;
                canvas1.Children.Add(tail2L);


                //3
                Ellipse tail3 = new Ellipse();
                tail3.Width = 80;
                tail3.Height = 80;
                tail3.VerticalAlignment = VerticalAlignment.Top;
                tail3.HorizontalAlignment = HorizontalAlignment.Left;
                tail3.Margin = new Thickness(157, 150, 0, 0);
                tail3.Fill = Brushes.Thistle;
                tail3.Stroke = Brushes.Orchid;
                tail3.StrokeThickness = 1;
                canvas1.Children.Add(tail3);

                Polygon tail3P = new Polygon();
                tail3P.Points = new PointCollection();
                tail3P.Points.Add(new Point(160, 177));
                tail3P.Points.Add(new Point(235, 202));
                tail3P.Points.Add(new Point(300, 250));
                tail3P.Points.Add(new Point(140, 230));
                tail3P.Stroke = Brushes.White;
                tail3P.Fill = Brushes.White;
                canvas1.Children.Add(tail3P);

                Line tail3L = new Line();
                tail3L.X1 = 160;
                tail3L.Y1 = 177;
                tail3L.X2 = 235;
                tail3L.Y2 = 202;
                tail3.StrokeThickness = 1;
                tail3L.Stroke = Brushes.Orchid;
                canvas1.Children.Add(tail3L);

            }

            TextBlock text = new TextBlock();
            text.Text = "Мой одногруппник Паша";
            text.Margin = new Thickness(200, 217, 0, 0);
            text.FontSize = 20;
            text.FontStyle = FontStyles.Italic;
            canvas1.Children.Add(text);
            //-----------------------------------------------


            BezierSegment bezier1 = new BezierSegment();

            bezier1.Point1 = new Point(258,230);
            bezier1.Point2 = new Point(374,290);
            bezier1.Point3 = new Point(432,260);
            bezier1.IsStroked = true;
            BezierSegment bezier2 = new BezierSegment();

            bezier2.Point1 = new Point(216, 330);
            bezier2.Point2 = new Point(200, 260);
            bezier2.Point3 = new Point(432, 280);
            bezier2.IsStroked = true;
            
            PathFigure figure = new PathFigure();

            figure.Segments.Add(bezier1);
            figure.StartPoint = new Point(200,260);
            figure.Segments.Add(bezier2);

            Path path = new Path();
            path.Stroke = Brushes.Black;
            path.Data = new PathGeometry(new PathFigure[] { figure });
            
            canvas1.Children.Add(path);



        }

        private void clearB_Click(object sender, RoutedEventArgs e)
        {
            canvas1.Children.Clear();
        }


    }
}
