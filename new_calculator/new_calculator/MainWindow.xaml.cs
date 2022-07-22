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

namespace new_calculator
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
        int x, y;
        char o;
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            string a = b1.Content.ToString();
            text1.Text += a;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            string a = b2.Content.ToString();
            text1.Text += a;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            string a = b3.Content.ToString();
            text1.Text += a;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            string a = b4.Content.ToString();
            text1.Text += a;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            string a = b5.Content.ToString();
            text1.Text += a;
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            string a = b6.Content.ToString();
            text1.Text += a;
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            string a = b7.Content.ToString();
            text1.Text += a;
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            string a = b8.Content.ToString();
            text1.Text += a;
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            string a = b9.Content.ToString();
            text1.Text += a;
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            string a = b0.Content.ToString();
            text1.Text += a;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            x = int.Parse(text1.Text);
            text1.Text = "";
            o = '*';
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            x = int.Parse(text1.Text);
            text1.Text = "";
            o = '-';
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            x = int.Parse(text1.Text);
            text1.Text = "";
            o = '+';
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            x = int.Parse(text1.Text);
            text1.Text = "";
            o = '/';
        }

        private void bp_Click(object sender, RoutedEventArgs e)
        {
            x = int.Parse(text1.Text);
            text1.Text = "";
            o = '%';
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            y = int.Parse(text1.Text);
            int answer = 0;
            if(o=='+')
            {
                answer = x + y;
            }
            else if(o=='-')
            {
                answer = x - y;
            }
            else if(o=='*')
            {
                answer = x * y;
            }
            else if(o=='/')
            {
                answer = x / y;
            }
            else if(o=='%')
            {
                answer = x % y;
            }
            text1.Text = answer.ToString();
        }
    }
}
