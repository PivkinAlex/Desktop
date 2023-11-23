using MK.Rep;
using MK.Windows;
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

namespace MK.Pages.Theme
{
    /// <summary>
    /// Логика взаимодействия для Prilagatel.xaml
    /// </summary>
    public partial class Prilagatel : Page
    {
        Repository _repository;
        public Prilagatel()
        {
            InitializeComponent();
        }

        private void HelpPrilagatelButton_Click(object sender, RoutedEventArgs e)
        {
            var wind = new PrilagatelHelp();
            wind.Show();
        }

        private void ExitPrilagatelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThemesPage(_repository));
        }
        private void StopPadezhiButton_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            var textBoxes = new List<TextBox> { TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8 };
            var textBoxesRes = new List<string> { "Кудонь", "Вирень", "Ляень", "Шабань", "Катонь", "Тишень", "Траксонь", "Пичень" };
            for (int i = 0; i < textBoxes.Count; i++)
            {
                TextBox textBox = textBoxes[i];
                string text = textBoxesRes[i];
                textBox.IsEnabled = false;

                if (textBox.Text == text)
                {
                    n++;
                    Brush newBrush = new SolidColorBrush(Colors.Green);
                    textBox.Foreground = newBrush;
                }
                else
                {
                    Brush newBrush = new SolidColorBrush(Colors.Red);
                    textBox.Foreground = newBrush;
                }

            }
            double RES = Math.Round(((n * 100.0) / 8.0), 2);
            var wind = new Result(RES);
            wind.Show();
        }
    }
}

    
