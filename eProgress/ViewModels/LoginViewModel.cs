using eProgress.Classes;
using eProgress.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace eProgress.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private LoginWindow _loginWindow { get; set; }

        private string login;
        public string Login { get => login; set => SetProperty(ref login, value); }

        public string Senha { get; set; }
        public LoginViewModel(LoginWindow loginWindow)
        {
            _loginWindow = loginWindow;
            MessageBoxCommand = new Command(() => {
                MessageBox.Show("Eae");
            });

            MessageBoxCommand = new Command(() => {
                MessageBox.Show("Eae");
            });

        }
        public Command MessageBoxCommand { get; }

        public Command CarregarGridCommand { get; }

    }
}
