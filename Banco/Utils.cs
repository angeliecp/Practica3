using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Banco
{
    public static class Utils
    {
        public static void RenderizarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                BIENVENIDO AL SISTEMA BANCARIO               ***");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                       MENU DE OPCIONES                      ***");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("*** [1] Crear Cliente - [2] Depositar - [3] Retirar             ***");
            Console.WriteLine("*** [4] Consultar Balance - [0] Salir                           ***");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public static void RenderizarMenuCrearCliente()
        {
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                BIENVENIDO AL SISTEMA BANCARIO               ***");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                         CREAR CLIENTE                       ***");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Presiona [Enter] para regresar al menú principal.");
        }

        public static void RenderizarMenuDepositar()
        {
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine("***          BIENVENIDO AL SISTEMA BANCARIO          ***");
            Console.WriteLine("********************************************************");
            Console.WriteLine("***                     DEPOSITAR                    ***");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Presiona [Enter] para regresar al menú principal.");
        }

        public static void RenderizarMenuRetirar()
        {
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine("***          BIENVENIDO AL SISTEMA BANCARIO          ***");
            Console.WriteLine("********************************************************");
            Console.WriteLine("***                      RETIRAR                     ***");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Presiona [Enter] para regresar al menú principal.");
        }

        public static void RenderizarMenuConsultarBalance()
        {
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine("***          BIENVENIDO AL SISTEMA BANCARIO          ***");
            Console.WriteLine("********************************************************");
            Console.WriteLine("***                 CONSULTAR BALANCE                ***");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Presiona [Enter] para regresar al menú principal.");
        }
    }
}
