using static MK.Pages.Themes.Padezhi;
using MK.Pages;
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
using System.Windows.Controls.Primitives;

namespace MK.Pages.Themes
{
    /// <summary>
    /// Логика взаимодействия для Padezhi.xaml
    /// </summary>
    public partial class Padezhi : Page
    {
        public Padezhi()
        {
            InitializeComponent();
        }

       

        private void HelpPadezhiButton_Click(object sender, RoutedEventArgs e)
        {
            var wind = new PadezhiHelp();
            wind.Show();
        }

        private void ExitPadezhiButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThemesPage());
        }

        private void StopPadezhiButton_Click(object sender, RoutedEventArgs e)
        {
            int n=0;
            var textBoxes = new List<TextBox> { TextBox1, TextBox2, TextBox3,
                                                TextBox4, TextBox5, TextBox6,
                                                TextBox7, TextBox8, TextBox9,
                                                TextBox10, TextBox11, TextBox12};
            var textBoxesRes = new List<String>{ "", "онь", "онди", "та","са","ста",
                                                "у","га","шка","фтома","кс", "онкса" };
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
            double RES = Math.Round(((n * 100.0) / 12.0), 2);         
            var wind = new Result(RES);
            wind.Show();

            //NavigationService.Navigate(new Result(RES));
        }
        
    }
}
