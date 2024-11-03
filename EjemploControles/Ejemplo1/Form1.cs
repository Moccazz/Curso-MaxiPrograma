using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            listView1.Items.Add(elemento);

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            cbPokemonFavorito.Items.Add("Ivysaur");
            cbPokemonFavorito.Items.Add("Chicorita");
            cbPokemonFavorito.Items.Add("Sceptile");
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //Operador ternario
            string pokemon = CheckAtrapar.Checked == true ? "Tiene un pokemon" : "No tiene un pokemon";
            string tipo1;

            if (radioElectrico.Checked)
                tipo1 = "Electrico";
            else if (radioFantasma.Checked)
                tipo1 = "Fantasma";
            else if (radioFantasma.Checked)
                tipo1 = "Planta";
            else if (radioFuego.Checked)
                tipo1 = "Fuego";
            else if (radioAgua.Checked)
                tipo1 = "Agua";
            else if (radioOscuridad.Checked)
                tipo1 = "Oscuridad";
            else if (radioHada.Checked)
                tipo1 = "Hada";
            else if (radioPsiquico.Checked)
                tipo1 = "Psiquico";
            else  
                tipo1 = "Hielo";
                

            string pokemonFavorito = cbPokemonFavorito.SelectedItem.ToString();
            string numeroPokedex = numeroPokedexBox.Value.ToString();
            if (numeroPokedexBox.Value < 0 && numeroPokedexBox.Value > 80)
            {
                MessageBox.Show("Este pokemon no esta registrado en la pokedex");
            }

            
            string mensaje = pokemon + ", es" + tipo1 + ", pokemon favorito es" + pokemonFavorito + ", su numero es: " + numeroPokedex;
            MessageBox.Show("Nombre: " + nombre + "Fecha: " + fecha + ", " + mensaje);
        }

    
    }
}
