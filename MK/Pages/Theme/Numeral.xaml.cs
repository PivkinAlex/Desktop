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
    /// Логика взаимодействия для Numeral.xaml
    /// </summary>
    public partial class Numeral : Page
    {
        public Numeral()
        {
            InitializeComponent();
        }

        private void HelpNumeralButton_Click(object sender, RoutedEventArgs e)
        {
            var wind = new NumeralHelp();
            wind.Show();
        }

        private void ExitNumeralButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThemesPage()); 
        }
    }
}
