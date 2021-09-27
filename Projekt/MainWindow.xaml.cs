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

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int firstnum;
        int secnum;
        int total;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {

            firstnum = Convert.ToInt32(numA.Text);
            secnum = Convert.ToInt32(numB.Text);

            total = firstnum + secnum;

            WynikA.Content = total.ToString();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

            firstnum = Convert.ToInt32(numA.Text);
            secnum = Convert.ToInt32(numB.Text);

            total = firstnum - secnum;

            WynikA.Content = total.ToString();
        }

        private void Mno_Click(object sender, RoutedEventArgs e)
        {

            firstnum = Convert.ToInt32(numA.Text);
            secnum = Convert.ToInt32(numB.Text);

            total = firstnum * secnum;

            WynikA.Content = total.ToString();
        }

        private void Dzie_Click(object sender, RoutedEventArgs e)
        {

            firstnum = Convert.ToInt32(numA.Text);
            secnum = Convert.ToInt32(numB.Text);

            total = firstnum / secnum;

            WynikA.Content = total.ToString();
        }

        private void Window_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numE_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numG_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numH_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
