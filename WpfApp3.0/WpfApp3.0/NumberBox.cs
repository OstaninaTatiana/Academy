using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

namespace WpfApp3._0
{
    public class NumberBox : Border
    {
        private TextBox txt;
        private Button btn1, btn2;
        private double widht, height;
        private Thickness margin;
        private int content;

        public NumberBox() : base()
        {
            txt = new TextBox();
            txt.HorizontalAlignment = HorizontalAlignment.Left;
            txt.VerticalAlignment = VerticalAlignment.Top;
            btn1 = new Button();
            btn1.HorizontalAlignment = HorizontalAlignment.Left;
            btn1.VerticalAlignment = VerticalAlignment.Top;
            btn1.Content = "+";
            btn1.FontSize = 30;
            btn1.Click += PlusEvent;
            btn2 = new Button();
            btn2.HorizontalAlignment = HorizontalAlignment.Left;
            btn2.VerticalAlignment = VerticalAlignment.Top;
            btn2.Content = "-";
            btn2.FontSize = 30;
            btn2.Click += MinusEvent;
            txt.Text = "0";
            txt.FontSize = 30;
            txt.TextChanged += NewContent;
        }

        public RoutedEvent ValueChanged = EventManager.RegisterRoutedEvent("ValueChange", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(NumberBox));

        public event RoutedEventHandler ValueChange
        {
            add
            {
                AddHandler(ValueChanged, value);
            }
            remove
            {
                RemoveHandler(ValueChanged, value);
            }
        }

        private void PlusEvent(object sender, RoutedEventArgs e)
        {
            Content += 1;
        }

        private void MinusEvent(object sender, RoutedEventArgs e)
        {
            Content -= 1;
        }

        private void NewContent(object sender, RoutedEventArgs e)
        {
            int.TryParse(txt.Text, out content);
        }

        public double Width
        {
            get
            {
                return widht;
            }
            set
            {
                this.widht = value;
                txt.Width = this.Width / 2;
                btn1.Width = this.Width / 2;
                btn2.Width = this.Width / 2;
            }
        }
        
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                this.height = value;
                txt.Height = this.Height;
                btn1.Height = this.Height / 2;
                btn2.Height = this.Height / 2;
            }
        }

        public Thickness Margin
        {
            get
            {
                return this.margin;
            }
            set
            {
                this.margin = value;
                txt.Margin = new Thickness(this.Margin.Left, this.Margin.Top, 0, 0);
                btn1.Margin = new Thickness(this.Margin.Left + txt.Width, this.Margin.Top, 0, 0);
                btn2.Margin = new Thickness(this.Margin.Left + txt.Width, this.Margin.Top + txt.Height / 2, 0, 0);
            }
        }

        public int Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                txt.Text = this.Content.ToString();
            }
        }


        override protected void OnVisualParentChanged(DependencyObject OldParent)
        {
            Grid grid = VisualParent as Grid;
            grid.Children.Add(txt);
            grid.Children.Add(btn1);
            grid.Children.Add(btn2);
        }



    }
}
