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
    }
}
