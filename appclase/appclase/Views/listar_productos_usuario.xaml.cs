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
    public partial class listar_productos_usuario : ContentPage
    {
        private Api api = new Api();
        public listar_productos_usuario()
        {
            InitializeComponent();
            GetProductosUsua();
        }

        private async void GetProductosUsua()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(api.url + "/productos/listar");
            var listar_productos = JsonConvert.DeserializeObject<List<Lista_productos_usuario>>(response);
            Listado_producto_usua.ItemsSource = listar_productos;
        }
    }
    
}