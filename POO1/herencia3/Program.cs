using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Gato g1 = new Gato();
            g1.Nombre = "roberto";

            Perro p1 = new Perro();
            p1.Nombre = "Perro pluma";

            List<Animal> animales = new List<Animal>();
            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Aguila());
            animales.Add(new Perro());
            animales.Add(new Canario());

            List<Flyable> listaVoladores = new List<Flyable>();

            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());


            //foreach (Animal item in animales)
            //{
            //    Console.WriteLine(item.comunicarse());
            //}



            Console.ReadKey();
        }
    }
}
