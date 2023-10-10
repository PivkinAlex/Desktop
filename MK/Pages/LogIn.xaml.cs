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
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
            Password.PasswordChar= '\0';
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration());
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration());
        }

        
        private void Login_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "Введите логин")
            {
                Login.Text = "";
                Login.Foreground = Brushes.Black; // Установите цвет текста по вашему желанию
            }
        }
        private void Login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Login.Text))
            {
                Login.Text = "Введите логин";
                Login.Foreground = Brushes.Gray; // Установите цвет текста подсказки
            }
        }
      

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
