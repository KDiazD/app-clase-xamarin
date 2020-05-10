
namespace appclase.ViewModels
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Views;
    using System.Collections.ObjectModel;

    class MainViewModel
    {
        public LoginViewModel Login { get; set; }
        public RegistroViewModel Registro{ get; set; }

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }

        public ICommand RegistroCommand
        {
            get
            {
                return new RelayCommand(GoToRegistro);
            }
        }

        private async void GoToRegistro()
        {
            this.Registro = new RegistroViewModel();
            await App.Navigator.PushAsync(new RegistroPage());
        }
    }
}
