using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        //          - Codigo de articulo(3 digitos no correlativos)
        //          - Precio
        //          - Codigo de marca (1 a 10)
        //private int codArticulo;
        // this.precio , this.codMarca
        private float precio;
        private int codMarca;

        public int CodigoArticulo { get; set; }

        public float Precio { get; set; }

        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
            if (value > 0 && value < 11)
                {
                    codMarca = value;
                }
            else
                {
                    codMarca = -1;
                }
            }

        }
    }
}
