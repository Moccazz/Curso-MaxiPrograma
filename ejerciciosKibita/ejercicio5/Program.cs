using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Escribe un programa en C# que genere una tabla de multiplicación del 1 al 10
            //para un número ingresado por el usuario. Utiliza un bucle for para iterar sobre los números del 1 al 10 y mostrar el resultado de la multiplicación.
            Console.WriteLine("Ingresar un numero: ");
            int num = int.Parse(Console.ReadLine());
            int multi = 0;
            for (int i = 0; i <= 10; i++)
            {
                multi = num * i;
                Console.WriteLine(multi);
            }
            Console.ReadKey();
        }
    }
}
