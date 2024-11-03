using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int intento = 0;
            int numSecreto = random.Next(1, 100);
            int totalIntentos = 0;

            Console.WriteLine("Adivina el numero secreto");

                do
                {
                Console.Write("Introduci el numero croissant: ");
                intento = int.Parse(Console.ReadLine());

                totalIntentos++;
                if (intento < numSecreto)
                {
                    Console.WriteLine("esta mas alto");
                }
                if (intento >  numSecreto)
                {
                    Console.WriteLine("esta mas bajo");
                }

            } while (intento != numSecreto);

            Console.WriteLine("Felicidades tio lo has conseguido!! facking mileurista, su numero de intentos totales fue de: " + totalIntentos);
            Console.ReadKey();
        }
    }
}
