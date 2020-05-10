using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using appclase.Models;
using appclase.ViewModels;
using appclase.Views;
using Xamarin.Forms;

namespace appclase.Models
{
    public class Login_models: INotifyPropertyChanged
    {


		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string nombre ="")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
		}
		private string usuario;

		public string Usuario
		{
			get { return usuario; }
			set { usuario = value;
				OnPropertyChanged();
			}
		}

		private string pass;


		public string Pass
		{
			get { return pass; }
			set { pass = value;
				OnPropertyChanged();
			}
		}


	}
}
