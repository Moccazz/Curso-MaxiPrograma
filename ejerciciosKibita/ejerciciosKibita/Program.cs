using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosKibita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Escribe un programa en C# que solicite al usuario un número entero positivo
            //y luego imprima todos los números pares desde 1 hasta ese número utilizando un bucle while.
            

            int cont = 1;
            Console.Write("Ingresar numero : ");
            int pares = int.Parse(Console.ReadLine());
            Console.WriteLine("hacer num de pares hasta  " + pares + ":");
            while (cont <= pares)
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine(cont);
                }
                cont++;
                Console.ReadKey();
            }
        }
    }
}
