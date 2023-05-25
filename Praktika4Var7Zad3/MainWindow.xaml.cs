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

namespace Praktika4Var7Zad3
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
            int number = int.Parse(txt1.Text);
            double value = 10;

            double a, c, h, S;

            switch (number)
            {
                case 1:
                    a = value;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    S = c * h / 2;
                    break;

                case 2:
                    c = value;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    S = c * h / 2;
                    break;
                case 3:
                    h = value;
                    c = h * 2;
                    a = c / Math.Sqrt(2);
                    S = c * h / 2;
                    break;
                case 4:
                    S = value;
                    c = Math.Sqrt(S * 4 / Math.Sqrt(2));
                    h = c / 2;
                    a = c / Math.Sqrt(2);
                    break;
                default:
                    Console.WriteLine("Некорректный номер элемента.");
                    return;
            }

            txt2.Text = $"a = {a}, c = {c}, h = {h}, S = {S}";

        }
    }
}
