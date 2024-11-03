using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funciones...
            Console.WriteLine(saludar("maxi"));
            

            int b = 10;
            int h = sumar(2, ref b);
            Console.WriteLine("La suma es " + h);
            Console.ReadKey();

        }
        static int sumar(int a, ref int z)
        {
            return a + z;
        }
        static string saludar(string nombre)
        {
            return nombre + "hola";
        }
    }
}
