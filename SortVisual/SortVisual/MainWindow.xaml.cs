using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SortVisual
{
    /// <summary>
    /// Designates a Windows Presentation Foundation application model with added functionalities.
    /// </summary>
    

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private int size = 0;
        private int[] arr;
        private Sorts sort;
        private int length;
        private int height;
        private DispatcherTimer clock = new DispatcherTimer();
        private bool automize = false;
        private bool set = false;
        private Visualize visual;
        private bool stop = false;

        public MainWindow()
        {
            InitializeComponent();
            clock.Tick += new EventHandler(next);
            
        }

        void init()
        {
            if (!set) return;
            stop = false;
            plane.Children.Clear();
            arr = new int[size];
            Random rnd = new Random(size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(0, height);
            }
        }

        private void setButton_Click(object sender, RoutedEventArgs e)
        {
            if (SizeBox.Text == null || typeBox.SelectedIndex < 1) return;
            set = true;
            size = Convert.ToInt32(SizeBox.Text);
            length = (int) plane.ActualHeight / size;
            if (length == 0) length++;
            height = (int) plane.ActualHeight / length;
            init();
            visual = new Visualize(plane, arr, size, length, length);

            switch (typeBox.Text)
            {
                case "Selection Sort":
                    sort = new Selection_Sort(visual, arr, size);
                    break;
                case "Insertion Sort":
                    sort = new Insertion_Sort(visual, arr, size);
                    break;
                
            }
        }

        private void initializeButton_Click(object sender, RoutedEventArgs e)
        {
            if (size != 0) init();
        }

        private void next(object sender, EventArgs e)
        {
            next();
        }

        private void next()
        {
            if (!set) return;
            if (stop) return;
            if (sort.next())
            {
                automize = false;
                clock.Stop();
                stop = true;
                MessageBox.Show("Finish Sorting!");
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)//TODO:implememting
        {
            next();
        }

        private void autoButton_Click(object sender, RoutedEventArgs e)
        {
            if (!set) return;
            clock.Interval = TimeSpan.FromMilliseconds(speedBox.Value);
            if (automize)
            {
                automize = false;
                clock.Stop();
            }
            else
            {
                automize = true;//TODO: implementing
                clock.Start();
            }
        }

        private void resultButton_Click(object sender, RoutedEventArgs e)//TODO:depends to implment
        {

        }

        private void speedBox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            clock.Interval = TimeSpan.FromMilliseconds(speedBox.Value);
        }
    }
}
