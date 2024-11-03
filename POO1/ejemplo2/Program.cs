using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      Primer lote con 10 registros de productos, cada producto tiene:    
            //          - Codigo de articulo (3 digitos no correlativos)
            //          - Precio
            //          - Codigo de marca (1 a 10)
            //      Segundo lote con las ventas de la semana. Cada venta tiene:
            //          - Codigo de articulo
            //          - Cantidad
            //          - Codigo de cliente ( 1 a 100)
            //      Este lote corta con codigo de cleinte 0.
            //
            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo(3, 4);
                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Codigo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Codigo de marca: ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());

            }

            //carga de vector completo
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Codigo Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            
            
            while (venta.CodigoCliente != 0)
            {
                
                Console.WriteLine("Codigo Articulo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Codigo Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }

        }
    }
}
