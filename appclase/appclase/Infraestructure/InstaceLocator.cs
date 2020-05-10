using appclase.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace appclase.Infraestructure
{
    class InstaceLocator
    {
        public MainViewModel Main { get; set; }

        public InstaceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
