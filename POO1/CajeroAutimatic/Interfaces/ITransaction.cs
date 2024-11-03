using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutimatic.Interfaces
{
    internal interface ITransaction
    {
        void Agregar(float DineroActual, Usuario DineroAdd );

        void Retirar(float DineroActual, Usuario DineroRemove);
    }
}
