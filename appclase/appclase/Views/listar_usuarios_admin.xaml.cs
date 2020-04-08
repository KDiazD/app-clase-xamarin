using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using System.Net.Http;
using appclase.Views;
using appclase.Models;

namespace appclase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class listar_usuarios_admin : ContentPage
    {
        private Api api = new Api();
        public listar_usuarios_admin()
        {
            InitializeComponent();
            GetUsuarios();
        }

        private async void GetUsuarios()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(api.url + "/usuarios/listar");
            var listar_usuarios = JsonConvert.DeserializeObject<List<Lista_usuarios>>(response);
            Listado_usuarios_admin.ItemsSource = listar_usuarios;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Holii" , "Tas creando un usuario pero aun no funciona jijiji ", "OK");
        }
    }
}