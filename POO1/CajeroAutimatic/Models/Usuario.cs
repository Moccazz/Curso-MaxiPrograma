using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutimatic
{
    internal class Usuario 
    {
        public string Username { get; set; }
        public string Contrasenia { get; set; }

        public float Dinero { get; set; }


        public Usuario(string Id, string Contrasenia)
        {
            this.Username = Id;
            this.Contrasenia = Contrasenia;

        }

        public Usuario()
        {

        }


    }
}
   