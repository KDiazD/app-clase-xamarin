using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using appclase.Models;
using appclase.Views;

namespace appclase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista_productos_vendidos : ContentPage
    {
        public Lista_productos_vendidos()
        {
            InitializeComponent();
        }
    }
}