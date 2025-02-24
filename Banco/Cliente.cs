using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Banco
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nombre, string cedula)
        {
            Nombre = nombre;
            Cedula = cedula;
        }
    }
}
