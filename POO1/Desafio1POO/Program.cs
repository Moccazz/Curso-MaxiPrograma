using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Constructor de Modelo y Marca
        Telefono t1 = new Telefono(" MOTOROLA ", " J7 ");
        Console.WriteLine("Marca: " + t1.Marca + "Modelo: " + t1.Modelo);


        Console.WriteLine("Ingrese numero telefonico: ");
        t1.NumeroTelefonico = Console.ReadLine();
        Console.WriteLine("Ingrese el codigo de operador: ");
        t1.CodigoOperador = int.Parse(Console.ReadLine());
        
            
        //Metodos Validar y Llamar
        Console.WriteLine(t1.Validar(t1.CodigoOperador));
        Console.WriteLine(t1.Llamar("a roberto"));
        Console.ReadKey();

        }
    }
}
