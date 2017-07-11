using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWebView.ViewModel
{
    public class MainPageViewModel
    {
        public string Endereco { get; set; }

        public MainPageViewModel()
        {
            Endereco = "https://www.google.com.br";
        }
    }
}
