using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3.Crea un programa en C# que imprima la serie de Fibonacci hasta el término n (ingresado por el usuario).
            //Utiliza un bucle for para generar la serie.
            int cont1 = 0;
            int cont2= 1;
            int cont3= 0;
            Console.WriteLine("Hasta que numero queres hacer la serie?: ");
            int numFinal = int.Parse(Console.ReadLine());
            for (int i = 0; i < numFinal; i++)
            {
                cont3 = cont2 + cont1;
                Console.WriteLine(cont3);
                cont1 = cont2;
                cont2 = cont3;
                
            }
            Console.ReadKey();
        }
    }
}
