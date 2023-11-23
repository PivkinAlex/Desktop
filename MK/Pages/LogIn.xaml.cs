using MK.Model;
using MK.Rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        Repository _repository;
        public LogIn(Repository repository)
        {
            InitializeComponent();
            _repository = repository;
            Password.PasswordChar= '\0';
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = new UserForLogin
            {
                Username =  Login.Text,
                Password = Password.Password
            };
            HttpResponseMessage response = await _repository.PostAuthenticationLogin(login);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.StatusCode.ToString());
                NavigationService.Navigate(new ThemesPage(_repository));
            }
            else
            {
                MessageBox.Show(response.StatusCode.ToString());
            }
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration(_repository));
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
