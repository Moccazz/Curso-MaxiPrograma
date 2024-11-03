using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //sobrecargar el constructor
        public Botella() { }



        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        //Propiedad
        //public int Capacidad 
        //{
        //    get { return capacidad; }
        //   set { capacidad = value; }
        //
        //}



        public string Material
        {
            get { return material; }
        }

        //Metodos
        public float recargar()
        {
            if (cantidadActual > 0) 
            {
                int diferencia = capacidad - cantidadActual;
                //100 = 50$
                //diferencia
                float monto = diferencia * 50 / 100;
                cantidadActual += diferencia; 
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }
        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            float monto = cantidad * 50 / 100;
            return monto;
        }
        public float descargar(int cantidad)
        {
        cantidadActual -= cantidad;
        return cantidadActual;
        }
    }
}
