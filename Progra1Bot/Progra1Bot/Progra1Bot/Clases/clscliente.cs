using System;
using System.Collections.Generic;
using System.Text;

namespace Progra1Bot.Clases
{
    class clscliente
    {
        public string recargas { get; set; }
        public string consultas { get; set; }
        public clscliente() { }
        public clscliente(string recargas, string consultas)
        {

            this.recargas = recargas;
            this.consultas=consultas;

        }
    }
}
