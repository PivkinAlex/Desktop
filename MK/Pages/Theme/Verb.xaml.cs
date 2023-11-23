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
    /// Логика взаимодействия для Verb.xaml
    /// </summary>
    public partial class Verb : Page
    {
        Repository _repository;
        public Verb()
        {
            InitializeComponent();
        }

      
        private void ExitVerbButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThemesPage(_repository));
        }

        private void HelpVerbButton_Click(object sender, RoutedEventArgs e)
        {
            var wind = new VerbHelp();
            wind.Show();
        }

        private void StopCasesButton_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            var textBoxes = new List<TextBox> { VerbTextBox1, VerbTextBox2, VerbTextBox3, VerbTextBox4, VerbTextBox5, VerbTextBox6, VerbTextBox7, VerbTextBox8};
            var textBoxesRes = new List<string>{ "кармай ласькома", "кармай удома", "кармай валома", "кармай рамама","кармай архтома","кармай арсема",
                                                "кармай симома","кармай лувома"};
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
