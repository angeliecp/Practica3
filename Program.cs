
using Practica3.Banco;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica3
{
    internal class Program
    {
        public static List<CuentaBancaria> cuentaBancarias = new List<CuentaBancaria>();
        static void Main(string[] args)
        {
            bool salirSistema = true;
            while (salirSistema)
            {
                int opcionMenu = 0;
                Utils.RenderizarMenuPrincipal();
                Console.Write("Digite el número de opción del Menú:> ");

                int.TryParse(Console.ReadLine(), out opcionMenu);
                //opciones del menu
                switch (opcionMenu)
                {
                    case 1:
                        var cliente = CrearCliente();
                        if (cliente != null)
                        {
                            cuentaBancarias.Add(new CuentaBancaria().RegistrarCliente(cliente));
                        }
                        break;
                    case 2:
                        Depositar();
                        break;
                    case 3:
                        Retirar();
                        break;
                    case 4:
                        ConsultarBalance();
                        break;
                    case 0:
                        salirSistema = false;
                        break;
                  
                }
            }
            Console.WriteLine("Saliendo del sistema...");
            Console.ReadKey();
        }

        private static void ConsultarBalance()
        {
            bool operacionenCurso = true;
            while (operacionenCurso)
            {
                Utils.RenderizarMenuConsultarBalance();
                Console.Write("> Ingrese la cedula del cliente:> ");

                string cedula = Console.ReadLine();

                if (!string.IsNullOrEmpty(cedula))
                {
                    var cliente = cuentaBancarias.Where(x => x.Cliente.Cedula == cedula)?.FirstOrDefault();
                    if (cliente != null)
                    {
                        operacionenCurso = false;
                        Utils.RenderizarMenuConsultarBalance();
                        Console.WriteLine("> Operacion completada con exito. " + cliente.ConsultarBalance());
                        Console.Write("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                }
            }
        }

        private static Cliente CrearCliente()
        {
            bool operacionenCurso = true;
            Cliente cliente = null;
          
            while (operacionenCurso)
            {
                Utils.RenderizarMenuDepositar();
                Console.Write("Ingrese el nombre del cliente:> ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la cedula del cliente:> ");
                string cedula = Console.ReadLine();

                Utils.RenderizarMenuDepositar();

                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(cedula))
                {
                    cliente = new Cliente(nombre, cedula);
                    operacionenCurso = false;

                    Console.WriteLine("> El cliente: " + nombre + ", ha sido creado con exito.");
                    Console.Write("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No se han ingresado los datos de forma correcta, vuelva a intentarlo.");
                    Console.Write("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
            return cliente;
        }

        private static void Depositar()
        {
            bool operacionenCurso = true;
            while (operacionenCurso)
            {
                Utils.RenderizarMenuDepositar();
                Console.Write("> Ingrese la cedula del cliente:> ");

                string cedula = Console.ReadLine();

                if (!string.IsNullOrEmpty(cedula))
                {
                    var cliente = cuentaBancarias.Where(x => x.Cliente.Cedula == cedula)?.FirstOrDefault();
                    if (cliente != null)
                    {
                        //creamos el cliente
                        CuentaBancaria cuenta = new CuentaBancaria();

                        double monto = 0;
                        while (monto <= 0)
                        {
                            Utils.RenderizarMenuDepositar();
                            Console.WriteLine("> CLIENTE: " + cliente.Cliente.Nombre);
                            Console.WriteLine();
                            Console.Write("> Ingrese el monto a depositar:> ");

                            bool esValido = double.TryParse(Console.ReadLine(), out monto);
                            if (esValido)
                            {
                                if (monto > 0)
                                {
                                    cuenta.Depositar(monto);
                                    operacionenCurso = false;
                                    Console.WriteLine("> Operacion completada con exito. El nuevo balance es: " + cuenta.ConsultarSaldo());
                                    Console.Write("Presione cualquier tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                monto = 0;
                                Console.WriteLine("> El monto ingresado " + monto + " no es valido.");
                                Console.Write("Presione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                        }
                    }
                    else
                    {
                        Utils.RenderizarMenuDepositar();
                        Console.WriteLine("> No se ha encontrado ningun cliente con la cedula: "+ cedula);
                        Console.Write("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    operacionenCurso = false;
                }
            }
        }


        private static void Retirar()
        {
            bool operacionenCurso = true;
            while (operacionenCurso)
            {
                Utils.RenderizarMenuRetirar();
                Console.Write("> Ingrese la cedula del cliente:> ");

                string cedula = Console.ReadLine();

                if (!string.IsNullOrEmpty(cedula))
                {
                    var cliente = cuentaBancarias.Where(x => x.Cliente.Cedula == cedula)?.FirstOrDefault();
                    if (cliente != null)
                    {
                        
                        double monto = 0;
                        while (monto <= 0)
                        {
                            Utils.RenderizarMenuRetirar();
                            Console.WriteLine("> CLIENTE: " + cliente.Cliente.Nombre);
                            Console.WriteLine();
                            Console.Write("> Ingrese el monto a retirar:> ");

                            bool esValido = double.TryParse(Console.ReadLine(), out monto);
                            if (esValido)
                            {
                                var saldo = cliente.SaldoNeto();
                                if (saldo >= monto)
                                {
                                    cliente.Retirar(monto);
                                    operacionenCurso = false;
                                    Console.WriteLine("> Operacion completada con exito. El nuevo balance es: " + cliente.ConsultarSaldo());
                                    Console.Write("Presione cualquier tecla para continuar...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("> El cliente no cuenta con balance suficiente para realizar esta operación.");
                                    Console.Write("Presione cualquier tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                monto = 0;
                                Console.WriteLine("> El monto ingresado " + monto + " no es valido.");
                                Console.Write("Presione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                        }
                    }
                    else
                    {
                        Utils.RenderizarMenuRetirar();
                        Console.WriteLine("> No se ha encontrado ningun cliente con la cedula: " + cedula);
                        Console.Write("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    operacionenCurso = false;
                }
            }
        }
    }
}
