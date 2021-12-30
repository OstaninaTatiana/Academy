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
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(CreateButton);
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Start();
            Random random = new Random();
            btn1.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)));
        }

        private void CreateButton(object sender, EventArgs e)
        {
            Random random = new Random();
            Button btn2 = new Button();
            btn2.Content = "Тык";
            btn2.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)));
            btn2.Margin = new Thickness(random.Next(0, 300), random.Next(0, 300), 0, 0);
            btn2.HorizontalAlignment = HorizontalAlignment.Left;
            btn2.VerticalAlignment = VerticalAlignment.Top;
            btn2.FontSize = 50;
            btn2.Height = 150;
            btn2.Width = 150;
            btn2.MouseEnter += event1;
            btn2.MouseMove += event1;
            mainGrid.Children.Add(btn2);
        }

        private void event1(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            ((Button)sender).Margin = new Thickness(random.Next(0, 300), random.Next(0, 300), 0, 0);
        }


    }
}
