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

namespace Praktika4Var7Zad1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txt2.Text);
            double b = double.Parse(txt3.Text);
            double c;

            if (a == 1)
            {
                c = (b * 1);
                txt4.Text = ($"{c}");
            }
            else
                if(a == 2)
            {
                c = (b / 1000000);
                txt4.Text = ($"{c}");
            }
            else
                if(a == 3)
            {
                c = (b / 1000);
                txt4.Text = ($"{c}");
            }
            else
                if(a == 4)
            {
                c = (b * 1000);
                txt4.Text = ($"{c}");
            }
            else
                if(a == 5)
            {
                c = (b * 100);
                txt4.Text = ($"{c}");
            }
            else
                if(a > 5)
            {
                txt4.Text = ("Введите от 1-5");
            }

        }
    }
}
