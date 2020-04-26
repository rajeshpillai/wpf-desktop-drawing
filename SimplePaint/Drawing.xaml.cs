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
using System.Windows.Shapes;

namespace SimplePaint
{
    /// <summary>
    /// Interaction logic for Drawing.xaml
    /// </summary>
    public partial class Drawing : Window
    {
        public Drawing()
        {
            InitializeComponent();

            inkCanvas.DefaultDrawingAttributes.Color = Color.FromRgb(50, 220, 50);
        }

        void InkCanvas_StrokeCollected(object sender, InkCanvasStrokeCollectedEventArgs e)
        {
            var stroke = e.Stroke;
           // inkCanvas.Strokes.Remove(stroke);
            //inkPresenter.Strokes.Add(stroke);
            var bounds = stroke.GetBounds();
            var yellowRect = new Rectangle { Width = bounds.Width, Height = bounds.Height, Fill = Brushes.Transparent };
            //Canvas.SetLeft(yellowRect, bounds.X);
            //Canvas.SetTop(yellowRect, bounds.Y);
            //canvas.Children.Add(yellowRect);
        }
    }
}
