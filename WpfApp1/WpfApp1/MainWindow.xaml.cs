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

namespace WpfApp1
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

        private void clean(object sender, RoutedEventArgs e)
        {
            Label.Text = "";
        }

        private void send(object sender, RoutedEventArgs e)
        {
            if (Label.Text == "4863")
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

        private void BtnClicked(object sender, RoutedEventArgs e)
        {
            Label.Text += ((Button)sender).Content;
        }


    }
}
