using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Net.Http;
using appclase.Models;
using appclase.Views;

namespace appclase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class listar_pedidos_admin : ContentPage
    {
        private Api api = new Api();
        public listar_pedidos_admin()
        {
            InitializeComponent();
            Getpedidos();
        }

        private async void Getpedidos()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(api.url +"/pedidos/listar");
            var listar_pedidos = JsonConvert.DeserializeObject<List<Lista_pedidos>>(response);
            Listado_predidos_admin.ItemsSource = listar_pedidos;
           
        }
    }
}
