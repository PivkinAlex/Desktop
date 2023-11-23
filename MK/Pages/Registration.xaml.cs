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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        Repository _repository;
        public Registration(Repository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new LogIn(_repository));
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<string> roles = new List<string>
            {
                "Student"
            };
            var register = new UserForRegistration
            {
                UserName = UsernameTextBox.Text,
                Email = EmailTextBox.Text,
                Password = Password1.Password,
                Roles = roles

            };
            HttpResponseMessage response = await _repository.PostAuthenticationRegister(register);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success");
                NavigationService.Navigate(new LogIn(_repository));
            }
            else
            {
                MessageBox.Show(response.StatusCode.ToString());
            }
        }
    }
}
