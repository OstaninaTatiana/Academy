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

namespace WpfApp_Практика
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HorizontalHistogram a = new HorizontalHistogram();
            MainGrid.Children.Add(a);
            a.Values = new List<int> { 1, 5, 10, 2 };
            a.Height = 300;
            a.WidthCoefficient = 50;
            a.Margin = new Thickness(30, 30, 0, 0);
            this.Background = new SolidColorBrush(Color.FromArgb((byte)0, (byte)10, (byte)10, (byte)10));
            a.Recolor();
            a.Sort();
        }
    }
}
