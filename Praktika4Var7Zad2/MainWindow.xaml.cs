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

namespace Praktika4Var7Zad2
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
            int n = int.Parse(txt2.Text);
            int m = int.Parse(txt3.Text);
          


            string cardName;
            switch (n)
            {
                case 6:
                    cardName = "шестёрка";
                    break;

                case 7:
                    cardName = "семёрка";
                    break;

                case 8:
                    cardName = "восьмёрка";
                    break;

                case 9:
                    cardName = "девятка";
                    break;

                case 10:
                    cardName = "десятка";
                    break;

                case 11:
                    cardName = "валет";
                    break;

                case 12:
                    cardName = "дама";
                    break;

                case 13:
                    cardName = "король";
                    break;

                case 14:
                    cardName = "туз";
                    break;

                default:
                    cardName = "неизвестное достоинство";
                    break;
            }

            string cardName1;
            switch (m)
            {
                case 1:
                    cardName1 = "пик";
                    break;

                case 2:
                    cardName1 = "треф";
                    break;

                case 3:
                    cardName1 = "бубен";
                    break;

                case 4:
                    cardName1 = "червей";
                    break;

                default:
                    cardName1 = "неизвестноя масть";
                    break;
            }
            txt4.Text = $"{cardName}  {cardName1}";
        }
    }
}
