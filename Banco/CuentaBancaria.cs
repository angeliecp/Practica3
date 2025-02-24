using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Banco
{
    public class CuentaBancaria
    {
        public Cliente Cliente {  get; set; }
        protected static double Saldo { get; set; }
        public CuentaBancaria()
        {
            
        }

        public CuentaBancaria RegistrarCliente(Cliente cliente)
        {
            Cliente = cliente;
            Saldo = 0;
            return this;
        }
        public string Depositar(double monto)
        {
            string resultado = "";
            if (monto > 0)
            {
                Saldo += monto;
                resultado = "Operación realizada con éxito.";
            }
            else
            {
                resultado = "Debe ingresar un monto mayor a 0.";
            }
            return resultado;
        }

        public string Retirar(double monto)
        {
            string resultado = "";
            if (monto > 0)
            {
                if (Saldo >= monto)
                {
                    Saldo -= monto;
                    resultado = "Operación realizada con éxito.";
                }
            }
            else
            {
                resultado = "Debe ingresar un monto mayor a 0.";
            }
            return resultado;
        }

        public string ConsultarBalance()
        {
            return "El saldo del cliente " + Cliente.Nombre + ", es de: RD" + Saldo.ToString("C2");
        }

        public string ConsultarSaldo()
        {
            return "RD"+Saldo.ToString("C2");
        }
        public double SaldoNeto()
        {
            return Saldo;
        }
    }
}
