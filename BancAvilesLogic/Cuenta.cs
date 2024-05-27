using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancAvilesLogic
{
    public class Cuenta
    {
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }
        public Cuenta(Cliente titular) { Titular = titular; Saldo = 0; }
        public void Ingresar(double cantidad) { Saldo += cantidad; }
        public void Extraer(double cantidad) { Saldo -= cantidad; }
    }
}
