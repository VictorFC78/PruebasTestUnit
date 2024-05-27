using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancAvilesLogic
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Cliente(string nombre, string apellidos)
        { Nombre = nombre; Apellidos = apellidos; }

    }
}
