using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace appclase.Models
{
    public class Lista_productos_usuario
    {
        public string nombre_producto { get; set; }
        public double valor { get; set; }
        public string codigo { get; set; }
        public string url_img { get; set; }
    }
}
