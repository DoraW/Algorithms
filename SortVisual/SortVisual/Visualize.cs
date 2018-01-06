using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SortVisual
{
    class Visualize
    {
        private Canvas plane;
        private Rectangle[] rect;
        private int[] arr;
        private int size;
        private int width;
        private int height;

        private void setRect(Rectangle rectangle, double left, double top, int val)
        {
            rectangle.Margin = new Thickness(left, top, 0, 0);
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Stroke = Brushes.Brown;
            rectangle.ToolTip = val;
            plane.Children.Add(rectangle);
        }

        public Visualize(Canvas plane, int[] arr, int size, int width, int height)
        {
            this.plane = plane;
            this.arr = arr;
            this.size = size;
            this.width = width;
            this.height = height;

            rect = new Rectangle[size];

            for (int i = 0; i < size; i++)
            {
                rect[i] = new Rectangle();
                rect[i].Margin = new Thickness((double)width * i, plane.ActualHeight - (double)height * arr[i] - height, 0, 0);
                rect[i].Width = width;
                rect[i].Height = height;
                rect[i].Stroke = Brushes.Brown;
                rect[i].ToolTip = arr[i];
                plane.Children.Add(rect[i]);
            }
        }


        public void swap(int p, int q)
        {
            //int temp = arr[p];
            //arr[p] = arr[q];
            //arr[q] = temp;

            Rectangle p1 = new Rectangle(), p2 = new Rectangle();
            setRect(p2, rect[q].Margin.Left, rect[p].Margin.Top, arr[p]);
            setRect(p1, rect[p].Margin.Left, rect[q].Margin.Top, arr[q]);

            rect[p].Visibility = Visibility.Hidden;
            rect[q].Visibility = Visibility.Hidden;

            rect[p] = p1;
            rect[q] = p2;

            plane.Children.Remove(rect[p]);
            plane.Children.Remove(rect[q]);
            plane.Children.Add(rect[p]);
            plane.Children.Add(rect[q]);

        }
    }
}
