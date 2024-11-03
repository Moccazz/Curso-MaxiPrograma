using CajeroAutimatic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutimatic.Implementations
{
    internal class TransactionImplementation : ITransaction
    {
        public void Agregar(float DineroAdd, Usuario Activo)
        {
            Activo.Dinero += DineroAdd;
        }

        public void Retirar(float DineroRemove, Usuario activo )
        {
            activo.Dinero -= DineroRemove;
        }
    }
}
