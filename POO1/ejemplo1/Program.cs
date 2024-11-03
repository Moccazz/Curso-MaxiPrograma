using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre
            //int edad;
            //float sueldo;
            //string nombre;

            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            //Persona p1 = new Persona("roberto");
            //p1.setEdad(20);
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar(" santy "));
            //Console.WriteLine("la edad de la persona es : " + p1.getEdad());

            Botella b1 = new Botella("azul", "metal");
            Console.WriteLine("Capacidad botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: "+ b1.CantidadActual);
            b1.recargar(20);
            Console.WriteLine("Luego de recargar la cantidad actual es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar la cantidad actual es: " + b1.CantidadActual);
            b1.descargar(40);
            Console.WriteLine("Luego de Descargar la botella la cantidad actual es: " + b1.CantidadActual);
            Console.ReadKey();




            //b1.Capacidad = 200;
            //int algo = b1.Capacidad;




            //Perro perrito1 = new Perro();
            //perrito1.Edad = 35;
            //perrito1.Nombre = "wow";
            //perrito1.Raza = "Caniche toy";
            //int perrito_Edad = perrito1.Edad;
            //string perrito_Nombre = perrito1.Nombre;
            //string perrito_Raza = perrito1.Raza;

            //Console.WriteLine("el perro tiene la edad de: " + perrito_Edad);
            //Console.WriteLine("El perro tiene el nombre de: " + perrito_Nombre);
            //Console.WriteLine("El perro es de raza: " + perrito_Raza);
            //Console.ReadKey();
        }

    }
}
