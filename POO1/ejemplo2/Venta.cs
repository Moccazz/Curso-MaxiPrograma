﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Venta
    {
        // - Codigo de articulo
        // - Cantidad
        // - Codigo de cliente ( 1 a 100)
        public int CodigoArticulo { get; set; }
        public int Cantidad { get; set; }
        public int CodigoCliente { get; set; }
    }
}
