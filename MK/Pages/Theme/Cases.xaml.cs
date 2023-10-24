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
    /// Логика взаимодействия для Сases.xaml
    /// </summary>
    public partial class Cases : Page
    {
        public Cases()
        {
            InitializeComponent();
        }

        private void ExitCasesButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThemesPage());
        }

        private void HelpCasesButton_Click(object sender, RoutedEventArgs e)
        {
            var wind = new CasesHelp();
            wind.Show();
        }

        private void StopCasesButton_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            var RadioButtonKeys = new List<RadioButton> { CasesKey1, CasesKey2, CasesKey3, CasesKey4, CasesKey5, 
                CasesKey6, CasesKey7,CasesKey8, CasesKey9, CasesKey10, 
                CasesKey11, CasesKey12, CasesKey13, CasesKey14,CasesKey15,
                CasesKey16, CasesKey17, CasesKey18, CasesKey19,CasesKey20,
                CasesKey21, CasesKey22, CasesKey23, CasesKey24,CasesKey25};
            var radioButtonRes = new List<bool> { true, false, false, false, false, 
                false, false, true, false, false, 
                false, false, true, false, false,
                true, false, false, false, false,
                false, false, false, false, true }; 
            for (int i = 0; i < RadioButtonKeys.Count; i++)
            {
                RadioButton radioButton = RadioButtonKeys[i];
                bool ResultRadioButton = radioButtonRes[i];
                radioButton.IsEnabled = false;

                if ((radioButton.IsChecked == ResultRadioButton) && (ResultRadioButton == true))
                {
                    n++;
                    Brush newBrush = new SolidColorBrush(Colors.Green);
                    radioButton.Foreground = newBrush;
                }
                else if (((radioButton.IsChecked == true) && (ResultRadioButton == false)))
                {
                    Brush newBrush = new SolidColorBrush(Colors.Red);
                    radioButton.Foreground = newBrush;
                }

            }
            double RES = Math.Round(((n * 100.0) / 5.0), 2);
            var wind = new Result(RES);
            wind.Show();
        }
    }
}
