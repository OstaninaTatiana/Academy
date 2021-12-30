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

namespace WpfApp3
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
            timer.Tick += new EventHandler(OnTimeEvent);
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
        }

        private void OnTimeEvent(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void Shuffle()
        {
            Random random = new Random();
            int[] s = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index, temp;
            for (int i = 0; i < 10; i++)
            {
                index = random.Next(0, 9);
                temp = s[i];
                s[i] = s[index];
                s[index] = temp;
            }
            _1.Content = s[1];
            _2.Content = s[2];
            _3.Content = s[3];
            _4.Content = s[4];
            _5.Content = s[5];
            _6.Content = s[6];
            _7.Content = s[7];
            _8.Content = s[8];
            _9.Content = s[9];
            _0.Content = s[0];

            _1.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
            _2.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
            _3.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
            _4.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
            _5.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
            _6.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
            _7.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
            _8.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
            _9.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
            _0.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255), (byte)random.Next(50, 255)));
        }

        private void BtnClicked(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Shuffle();
            Label.Text += ((Button)sender).Content;
        }

        private void clean(object sender, RoutedEventArgs e)
        {
            Label.Text = "";
        }

        private void send(object sender, RoutedEventArgs e)
        {
            if (Label.Text.Length == 5)
            {
                Label.Text = "Успешно";
                Label.IsEnabled = false;
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                _0.IsEnabled = false;
                v.IsEnabled = false;
                x.IsEnabled = false;
            }
            else
            {
                Label.Text = "";
            }
        }
    }
}
