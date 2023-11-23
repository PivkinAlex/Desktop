using MK.Pages.Theme;
using MK.Pages.Themes;
using MK.Rep;
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

namespace MK
{
    /// <summary>
    /// Логика взаимодействия для Themes.xaml
    /// </summary>
    public partial class ThemesPage : Page
    {
        Repository _repository;
        public ThemesPage(Repository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new LogIn());
        }

        private void PadezhiTheme_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Padezhi());
        }

        private void PrilagatButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Prilagatel());
        }

        private void NumeralThemeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Numeral());
        }

        private void CasesThemesImage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cases());
        }

        private void ProposalThemesButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Proposal());
        }

        private void VerblThemesButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Verb());
        }
    }
}
