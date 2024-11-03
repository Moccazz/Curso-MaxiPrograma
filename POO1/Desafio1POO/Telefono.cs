using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1POO
{
    internal class Telefono
    {
        //Atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        // Constructores

        public Telefono () 
        { 

        }
        public Telefono (string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        //Propiedades
        public string Modelo
        {
            get { return modelo;}
        }
        public string Marca
        {
            get { return marca;}
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set  { codigoOperador = value; }
        }

        //Metodos
        public string Validar (int codigo)
        {
            if (codigo > 0 && codigo < 4)
            {
                return "Codigo valido";
            }
            else
            {
                return "Codigo Invalido";
            }
        }
        public string Llamar()
        {
            string llamada = "Realizando llamada";
            return llamada;
        }
        public string Llamar(string contacto)
        {
            return "Llamando a: " + contacto;
        }
    }
}

        
