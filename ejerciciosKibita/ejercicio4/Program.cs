using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Implementa un programa en C# que calcule la suma de los primeros n números naturales. El valor de n debe ser ingresado por el usuario.
            //Utiliza un bucle while para realizar la suma.

            int cont = 0;
            int suma = 0;

            int n = int.Parse(Console.ReadLine());
            while (cont <= n)
            {
                suma += cont;
                cont++;

            }
            Console.WriteLine(suma);
            Console.ReadKey();

        }
    }
}
