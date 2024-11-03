namespace Ejemplo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckAtrapar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioHielo = new System.Windows.Forms.RadioButton();
            this.radioFantasma = new System.Windows.Forms.RadioButton();
            this.radioOscuridad = new System.Windows.Forms.RadioButton();
            this.radioAgua = new System.Windows.Forms.RadioButton();
            this.radioFuego = new System.Windows.Forms.RadioButton();
            this.radioPsiquico = new System.Windows.Forms.RadioButton();
            this.radioHada = new System.Windows.Forms.RadioButton();
            this.radioPlanta = new System.Windows.Forms.RadioButton();
            this.radioElectrico = new System.Windows.Forms.RadioButton();
            this.labelPokemonFavorito = new System.Windows.Forms.Label();
            this.cbPokemonFavorito = new System.Windows.Forms.ComboBox();
            this.numeroPokedexBox = new System.Windows.Forms.NumericUpDown();
            this.numeroPokedex = new System.Windows.Forms.Label();
            this.botonPerfil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPokedexBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.Location = new System.Drawing.Point(16, 48);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(97, 13);
            this.labelNombreCompleto.TabIndex = 2;
            this.labelNombreCompleto.Text = "Nombre Completo: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(541, 153);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 88);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(2, 78);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.labelFechaNacimiento.TabIndex = 5;
            this.labelFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(119, 78);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(53, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "PERFIL ENTRENADOR POKEMON";
            // 
            // CheckAtrapar
            // 
            this.CheckAtrapar.AutoSize = true;
            this.CheckAtrapar.Location = new System.Drawing.Point(119, 115);
            this.CheckAtrapar.Name = "CheckAtrapar";
            this.CheckAtrapar.Size = new System.Drawing.Size(168, 17);
            this.CheckAtrapar.TabIndex = 8;
            this.CheckAtrapar.Text = "Ya atrapaste algun pokemon?";
            this.CheckAtrapar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioHielo);
            this.groupBox1.Controls.Add(this.radioFantasma);
            this.groupBox1.Controls.Add(this.radioOscuridad);
            this.groupBox1.Controls.Add(this.radioAgua);
            this.groupBox1.Controls.Add(this.radioFuego);
            this.groupBox1.Controls.Add(this.radioPsiquico);
            this.groupBox1.Controls.Add(this.radioHada);
            this.groupBox1.Controls.Add(this.radioPlanta);
            this.groupBox1.Controls.Add(this.radioElectrico);
            this.groupBox1.Location = new System.Drawing.Point(114, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 88);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // radioHielo
            // 
            this.radioHielo.AutoSize = true;
            this.radioHielo.Location = new System.Drawing.Point(204, 62);
            this.radioHielo.Name = "radioHielo";
            this.radioHielo.Size = new System.Drawing.Size(49, 17);
            this.radioHielo.TabIndex = 17;
            this.radioHielo.TabStop = true;
            this.radioHielo.Text = "Hielo";
            this.radioHielo.UseVisualStyleBackColor = true;
            // 
            // radioFantasma
            // 
            this.radioFantasma.AutoSize = true;
            this.radioFantasma.Location = new System.Drawing.Point(17, 39);
            this.radioFantasma.Name = "radioFantasma";
            this.radioFantasma.Size = new System.Drawing.Size(71, 17);
            this.radioFantasma.TabIndex = 10;
            this.radioFantasma.TabStop = true;
            this.radioFantasma.Text = "Fantasma";
            this.radioFantasma.UseVisualStyleBackColor = true;
            // 
            // radioOscuridad
            // 
            this.radioOscuridad.AutoSize = true;
            this.radioOscuridad.Location = new System.Drawing.Point(103, 62);
            this.radioOscuridad.Name = "radioOscuridad";
            this.radioOscuridad.Size = new System.Drawing.Size(73, 17);
            this.radioOscuridad.TabIndex = 14;
            this.radioOscuridad.TabStop = true;
            this.radioOscuridad.Text = "Oscuridad";
            this.radioOscuridad.UseVisualStyleBackColor = true;
            // 
            // radioAgua
            // 
            this.radioAgua.AutoSize = true;
            this.radioAgua.Location = new System.Drawing.Point(103, 40);
            this.radioAgua.Name = "radioAgua";
            this.radioAgua.Size = new System.Drawing.Size(50, 17);
            this.radioAgua.TabIndex = 13;
            this.radioAgua.TabStop = true;
            this.radioAgua.Text = "Agua";
            this.radioAgua.UseVisualStyleBackColor = true;
            // 
            // radioFuego
            // 
            this.radioFuego.AutoSize = true;
            this.radioFuego.Location = new System.Drawing.Point(103, 16);
            this.radioFuego.Name = "radioFuego";
            this.radioFuego.Size = new System.Drawing.Size(55, 17);
            this.radioFuego.TabIndex = 12;
            this.radioFuego.TabStop = true;
            this.radioFuego.Text = "Fuego";
            this.radioFuego.UseVisualStyleBackColor = true;
            // 
            // radioPsiquico
            // 
            this.radioPsiquico.AutoSize = true;
            this.radioPsiquico.Location = new System.Drawing.Point(204, 39);
            this.radioPsiquico.Name = "radioPsiquico";
            this.radioPsiquico.Size = new System.Drawing.Size(65, 17);
            this.radioPsiquico.TabIndex = 16;
            this.radioPsiquico.TabStop = true;
            this.radioPsiquico.Text = "Psiquico";
            this.radioPsiquico.UseVisualStyleBackColor = true;
            // 
            // radioHada
            // 
            this.radioHada.AutoSize = true;
            this.radioHada.Location = new System.Drawing.Point(204, 16);
            this.radioHada.Name = "radioHada";
            this.radioHada.Size = new System.Drawing.Size(51, 17);
            this.radioHada.TabIndex = 15;
            this.radioHada.TabStop = true;
            this.radioHada.Text = "Hada";
            this.radioHada.UseVisualStyleBackColor = true;
            // 
            // radioPlanta
            // 
            this.radioPlanta.AutoSize = true;
            this.radioPlanta.Location = new System.Drawing.Point(17, 62);
            this.radioPlanta.Name = "radioPlanta";
            this.radioPlanta.Size = new System.Drawing.Size(55, 17);
            this.radioPlanta.TabIndex = 11;
            this.radioPlanta.TabStop = true;
            this.radioPlanta.Text = "Planta";
            this.radioPlanta.UseVisualStyleBackColor = true;
            // 
            // radioElectrico
            // 
            this.radioElectrico.AutoSize = true;
            this.radioElectrico.Location = new System.Drawing.Point(17, 16);
            this.radioElectrico.Name = "radioElectrico";
            this.radioElectrico.Size = new System.Drawing.Size(66, 17);
            this.radioElectrico.TabIndex = 9;
            this.radioElectrico.TabStop = true;
            this.radioElectrico.Text = "Electrico";
            this.radioElectrico.UseVisualStyleBackColor = true;
            // 
            // labelPokemonFavorito
            // 
            this.labelPokemonFavorito.AutoSize = true;
            this.labelPokemonFavorito.Location = new System.Drawing.Point(128, 240);
            this.labelPokemonFavorito.Name = "labelPokemonFavorito";
            this.labelPokemonFavorito.Size = new System.Drawing.Size(96, 13);
            this.labelPokemonFavorito.TabIndex = 13;
            this.labelPokemonFavorito.Text = "Pokemon Favorito:";
            // 
            // cbPokemonFavorito
            // 
            this.cbPokemonFavorito.FormattingEnabled = true;
            this.cbPokemonFavorito.Location = new System.Drawing.Point(230, 237);
            this.cbPokemonFavorito.Name = "cbPokemonFavorito";
            this.cbPokemonFavorito.Size = new System.Drawing.Size(161, 21);
            this.cbPokemonFavorito.TabIndex = 14;
            // 
            // numeroPokedexBox
            // 
            this.numeroPokedexBox.Location = new System.Drawing.Point(230, 274);
            this.numeroPokedexBox.Name = "numeroPokedexBox";
            this.numeroPokedexBox.Size = new System.Drawing.Size(161, 20);
            this.numeroPokedexBox.TabIndex = 15;
            // 
            // numeroPokedex
            // 
            this.numeroPokedex.AutoSize = true;
            this.numeroPokedex.Location = new System.Drawing.Point(118, 276);
            this.numeroPokedex.Name = "numeroPokedex";
            this.numeroPokedex.Size = new System.Drawing.Size(107, 13);
            this.numeroPokedex.TabIndex = 16;
            this.numeroPokedex.Text = "Numero de Pokedex:";
            // 
            // botonPerfil
            // 
            this.botonPerfil.Location = new System.Drawing.Point(541, 109);
            this.botonPerfil.Name = "botonPerfil";
            this.botonPerfil.Size = new System.Drawing.Size(75, 23);
            this.botonPerfil.TabIndex = 17;
            this.botonPerfil.Text = "Ver Perfil";
            this.botonPerfil.UseVisualStyleBackColor = true;
            this.botonPerfil.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.botonPerfil);
            this.Controls.Add(this.numeroPokedex);
            this.Controls.Add(this.numeroPokedexBox);
            this.Controls.Add(this.cbPokemonFavorito);
            this.Controls.Add(this.labelPokemonFavorito);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CheckAtrapar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelNombreCompleto);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Formulario Entrenador Pokemon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPokedexBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckAtrapar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPokemonFavorito;
        private System.Windows.Forms.ComboBox cbPokemonFavorito;
        private System.Windows.Forms.NumericUpDown numeroPokedexBox;
        private System.Windows.Forms.Label numeroPokedex;
        private System.Windows.Forms.Button botonPerfil;
        private System.Windows.Forms.RadioButton radioHielo;
        private System.Windows.Forms.RadioButton radioFantasma;
        private System.Windows.Forms.RadioButton radioOscuridad;
        private System.Windows.Forms.RadioButton radioAgua;
        private System.Windows.Forms.RadioButton radioFuego;
        private System.Windows.Forms.RadioButton radioPsiquico;
        private System.Windows.Forms.RadioButton radioHada;
        private System.Windows.Forms.RadioButton radioPlanta;
        private System.Windows.Forms.RadioButton radioElectrico;
    }
}

