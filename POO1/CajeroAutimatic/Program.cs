using CajeroAutimatic.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutimatic
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Usuario Usuario = new Usuario();
            Usuario Usuario2 = new Usuario();
            Usuario Usuario3 = new Usuario();   
            TransactionImplementation Transaction = new TransactionImplementation();
            Usuario.Username = "pepe";
            Usuario.Contrasenia = "pepe123";
            Usuario2.Username = "pipo";
            Usuario2.Contrasenia = "pipo123";
            Usuario3.Username = "popo";
            Usuario3.Contrasenia = "popo123";
            Usuario.Dinero = 25.5f;
            Usuario2.Dinero = 60.5f;
            Usuario3.Dinero = 23.2f;
            string UsernameIngresado;
            string ContraseniaIngresada;
            int flag = 0;
            
            List<Usuario> UsuariosList = new List<Usuario>();
            UsuariosList.Add(Usuario2);
            UsuariosList.Add(Usuario);
            UsuariosList.Add(Usuario3);

            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Entrar a una cuenta");
            Console.WriteLine("2. Salir");
            int Opcion = int.Parse(Console.ReadLine());

            do
            {
            
                switch (Opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese Usuario");
                        UsernameIngresado = Console.ReadLine();
                        Console.WriteLine("Ingrese Contraseña");
                        ContraseniaIngresada = Console.ReadLine();
                        foreach (Usuario item in UsuariosList)
                        {
                            if (item.Username == UsernameIngresado && item.Contrasenia == ContraseniaIngresada)
                            {
                                Console.WriteLine("Has ingresado a la cuenta con exito, su dinero actual es: " + item.Dinero + " ¿Que desea hacer?");
                                Console.WriteLine("Elige una opción:");
                                Console.WriteLine("1. Agregar dinero");
                                Console.WriteLine("2. Retirar Dinero");
                                int OpcionCuenta = int.Parse(Console.ReadLine());
                                if (OpcionCuenta == 1)
                                {
                                    Console.WriteLine("Ingrese el monto a agregar");
                                    float val = float.Parse(Console.ReadLine());
                                    Transaction.Agregar(val, item);
                                    Console.WriteLine("Su dinero actual es: " + item.Dinero);
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese el monto a retirar");
                                    float val = float.Parse(Console.ReadLine());
                                    if (val > item.Dinero)
                                    {
                                        Console.WriteLine("Su cuenta no tiene suficiente dinero para retirar ese monto");
                                    }
                                    else
                                    {
                                        Transaction.Retirar(val, item);
                                        Console.WriteLine("Su dinero actual es: " + item.Dinero);
                                    }
                                }
                            }
                            else
                            {
                                flag += 1;
                            }
                        }
                        if (flag == 3)
                        {
                            Console.WriteLine("La contraseña o el usuario no existen");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Has salido con exito");
                        break;
                    case 3:
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        break;
                }
            }while (Opcion != 2);
        }
    }
}


