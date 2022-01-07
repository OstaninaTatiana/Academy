using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Практика
{
    class HorizontalHistogram : Border
    {
        private List<ProgressBar> progressBars;
        private List<int> values;
        private Thickness margin;
        private uint width_coefficient;

        private static RoutedEvent AmountOfRowsChanged = EventManager.RegisterRoutedEvent("AmountOfRowsChange", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(HorizontalHistogram));

        public event RoutedEventHandler AmountOfRowsChange
        {
            add
            {
                AddHandler(AmountOfRowsChanged, value);
            }
            remove
            {
                RemoveHandler(AmountOfRowsChanged, value);
            }
        }

        public HorizontalHistogram() : base()
        {
            progressBars = new List<ProgressBar>();
            values = new List<int>();
        }

        public List<int> Values
        {
            get
            {
                return values;
            }
            set
            {
                List<Brush> bufColors = Colors;
                if (this.Values.Count != value.Count)
                {
                    RaiseEvent(new RoutedEventArgs(AmountOfRowsChanged, this));
                }

                Grid grid = VisualParent as Grid;
                this.values = value;
                foreach (ProgressBar i in progressBars)
                {
                    if (grid != null)
                        grid.Children.Remove(i);
                }
                progressBars = new List<ProgressBar>();
                ProgressBar temp;
                int max;
                int counter = 0;
                try
                {
                    max = values.Max();
                }
                catch
                {
                    max = 1;
                }
                foreach (int i in values)
                {
                    temp = new ProgressBar();
                    temp.Height = this.Height / this.AmountOfRows / 10 * 9;
                    temp.Background = new SolidColorBrush(Color.FromArgb((byte)0, (byte)255, (byte)255, (byte)255));
                    temp.Width = max * this.WidthCoefficient;
                    temp.Value = (double)i / max * 100;
                    temp.BorderBrush = new SolidColorBrush(Color.FromArgb((byte)0, (byte)255, (byte)255, (byte)255));
                    temp.Margin = new Thickness(this.Margin.Left, this.Margin.Top + (counter * ((int)(this.Height / this.AmountOfRows))), 0, 0);
                    temp.HorizontalAlignment = HorizontalAlignment.Left;
                    temp.VerticalAlignment = VerticalAlignment.Top;
                    try
                    {
                        temp.Foreground = bufColors[counter];
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        ;
                    }
                    progressBars.Add(temp);
                    if (grid != null)
                        grid.Children.Add(temp);
                    counter++;
                }
            }
        }

        protected override void OnVisualParentChanged(DependencyObject OldParent)
        {
            List<Brush> bufColors = Colors;
            Grid grid = VisualParent as Grid;
            ProgressBar temp;
            int counter = 0;
            int max;
            try
            {
                max = values.Max();
            }
            catch 
            {
                max = 1;
            }
            foreach (int i in values)
            {
                temp = new ProgressBar();
                temp.Height = this.Height / this.AmountOfRows / 10 * 9;
                temp.Background = new SolidColorBrush(Color.FromArgb((byte)0, (byte)255, (byte)255, (byte)255));
                temp.Width = max * this.WidthCoefficient;
                temp.Value = (double)i / max * 100;
                temp.BorderBrush = new SolidColorBrush(Color.FromArgb((byte)0, (byte)255, (byte)255, (byte)255));
                temp.HorizontalAlignment = HorizontalAlignment.Left;
                temp.VerticalAlignment = VerticalAlignment.Top;
                temp.Margin = new Thickness(this.Margin.Left, this.Margin.Top + (counter * ((int)(this.Height / this.AmountOfRows))), 0, 0);
                try
                {
                    temp.Foreground = bufColors[counter];
                }
                catch (ArgumentOutOfRangeException)
                {
                    ;
                }
                progressBars.Add(temp);
                if (grid != null)
                    grid.Children.Add(temp);
                counter++;
            }
        }

        public int AmountOfRows
        {
            get
            {
                return Values.Count;
            }
        }

        public Thickness Margin
        {
            get
            {
                return margin;
            }
            set
            {
                margin = value;
                Values = values;
            }
        }

        public double Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Height = value;
                Values = values;
            }
        }

        public uint WidthCoefficient
        {
            get
            {
                return width_coefficient;
            }
            set
            {
                width_coefficient = value;
                Values = values;
            }
        }

        public void Recolor()
        {
            Random random = new Random();
            foreach (ProgressBar i in progressBars)
            {
                i.Foreground = new SolidColorBrush(Color.FromArgb((byte)255, (byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)));
            }
        }

        public List<Brush> Colors
        {
            get
            {
                List<Brush> brushes = new List<Brush>();
                foreach (ProgressBar i in progressBars)
                {
                    brushes.Add(i.Foreground);
                }
                return brushes;
            }
        }

        public double GetAvg()
        {
            return Values.Average();
        }

        public int GetMax()
        {
            return Values.Max();
        }

        public void Sort()
        {
            List<int> buf = Values;
            buf.Sort();
            Values = buf;
        }
    }
}
