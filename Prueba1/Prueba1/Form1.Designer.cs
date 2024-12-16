namespace Prueba1
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
            this.TextosAnteriores = new System.Windows.Forms.ListBox();
            this.CampoTexto = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreAnimal = new System.Windows.Forms.TextBox();
            this.Perro = new System.Windows.Forms.CheckBox();
            this.Gato = new System.Windows.Forms.ListBox();
            this.Dog = new System.Windows.Forms.ListBox();
            this.Fin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreNiño = new System.Windows.Forms.TextBox();
            this.Ninio = new System.Windows.Forms.ListBox();
            this.Ninia = new System.Windows.Forms.ListBox();
            this.Femenino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.AceptarAct3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Texto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rojo = new System.Windows.Forms.RadioButton();
            this.naranja = new System.Windows.Forms.RadioButton();
            this.azul = new System.Windows.Forms.RadioButton();
            this.colorFondo = new System.Windows.Forms.Label();
            this.verde = new System.Windows.Forms.RadioButton();
            this.morado = new System.Windows.Forms.RadioButton();
            this.rosado = new System.Windows.Forms.RadioButton();
            this.TamanioFuente = new System.Windows.Forms.Label();
            this.pequenio = new System.Windows.Forms.RadioButton();
            this.mediano = new System.Windows.Forms.RadioButton();
            this.grande = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TextosAnteriores
            // 
            this.TextosAnteriores.FormattingEnabled = true;
            this.TextosAnteriores.Location = new System.Drawing.Point(38, 139);
            this.TextosAnteriores.Name = "TextosAnteriores";
            this.TextosAnteriores.Size = new System.Drawing.Size(213, 95);
            this.TextosAnteriores.TabIndex = 4;
            this.TextosAnteriores.SelectedIndexChanged += new System.EventHandler(this.TextosAnteriores_SelectedIndexChanged);
            // 
            // CampoTexto
            // 
            this.CampoTexto.Location = new System.Drawing.Point(38, 58);
            this.CampoTexto.Name = "CampoTexto";
            this.CampoTexto.Size = new System.Drawing.Size(213, 20);
            this.CampoTexto.TabIndex = 5;
            this.CampoTexto.TextChanged += new System.EventHandler(this.CampoTexto_TextChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Aceptar.Location = new System.Drawing.Point(105, 100);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Actividad 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(387, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Actividad 2";
            // 
            // NombreAnimal
            // 
            this.NombreAnimal.Location = new System.Drawing.Point(390, 58);
            this.NombreAnimal.Name = "NombreAnimal";
            this.NombreAnimal.Size = new System.Drawing.Size(294, 20);
            this.NombreAnimal.TabIndex = 9;
            this.NombreAnimal.TextChanged += new System.EventHandler(this.NombreAnimal_TextChanged);
            // 
            // Perro
            // 
            this.Perro.AutoSize = true;
            this.Perro.Location = new System.Drawing.Point(444, 100);
            this.Perro.Name = "Perro";
            this.Perro.Size = new System.Drawing.Size(51, 17);
            this.Perro.TabIndex = 10;
            this.Perro.Text = "Perro";
            this.Perro.UseVisualStyleBackColor = true;
            this.Perro.CheckedChanged += new System.EventHandler(this.Perro_CheckedChanged);
            // 
            // Gato
            // 
            this.Gato.FormattingEnabled = true;
            this.Gato.Location = new System.Drawing.Point(394, 150);
            this.Gato.Name = "Gato";
            this.Gato.Size = new System.Drawing.Size(120, 95);
            this.Gato.TabIndex = 11;
            this.Gato.SelectedIndexChanged += new System.EventHandler(this.Gato_SelectedIndexChanged_1);
            // 
            // Dog
            // 
            this.Dog.FormattingEnabled = true;
            this.Dog.Location = new System.Drawing.Point(564, 150);
            this.Dog.Name = "Dog";
            this.Dog.Size = new System.Drawing.Size(120, 95);
            this.Dog.TabIndex = 12;
            this.Dog.SelectedIndexChanged += new System.EventHandler(this.Dog_SelectedIndexChanged);
            // 
            // Fin
            // 
            this.Fin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Fin.Location = new System.Drawing.Point(575, 94);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(75, 23);
            this.Fin.TabIndex = 13;
            this.Fin.Text = "Aceptar";
            this.Fin.UseVisualStyleBackColor = false;
            this.Fin.Click += new System.EventHandler(this.Fin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(830, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Actividad 3";
            // 
            // NombreNiño
            // 
            this.NombreNiño.Location = new System.Drawing.Point(836, 58);
            this.NombreNiño.Name = "NombreNiño";
            this.NombreNiño.Size = new System.Drawing.Size(294, 20);
            this.NombreNiño.TabIndex = 15;
            // 
            // Ninio
            // 
            this.Ninio.FormattingEnabled = true;
            this.Ninio.Location = new System.Drawing.Point(839, 165);
            this.Ninio.Name = "Ninio";
            this.Ninio.Size = new System.Drawing.Size(116, 69);
            this.Ninio.TabIndex = 16;
            // 
            // Ninia
            // 
            this.Ninia.FormattingEnabled = true;
            this.Ninia.Location = new System.Drawing.Point(998, 162);
            this.Ninia.Name = "Ninia";
            this.Ninia.Size = new System.Drawing.Size(132, 69);
            this.Ninia.TabIndex = 17;
            this.Ninia.SelectedIndexChanged += new System.EventHandler(this.Ninia_SelectedIndexChanged);
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Location = new System.Drawing.Point(935, 112);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(71, 17);
            this.Femenino.TabIndex = 18;
            this.Femenino.TabStop = true;
            this.Femenino.Text = "Femenino";
            this.Femenino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(839, 112);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(73, 17);
            this.Masculino.TabIndex = 19;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            this.Masculino.CheckedChanged += new System.EventHandler(this.Masculino_CheckedChanged);
            // 
            // AceptarAct3
            // 
            this.AceptarAct3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AceptarAct3.Location = new System.Drawing.Point(1055, 109);
            this.AceptarAct3.Name = "AceptarAct3";
            this.AceptarAct3.Size = new System.Drawing.Size(75, 23);
            this.AceptarAct3.TabIndex = 20;
            this.AceptarAct3.Text = "Aceptar";
            this.AceptarAct3.UseVisualStyleBackColor = false;
            this.AceptarAct3.Click += new System.EventHandler(this.AceptarAct3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(35, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Actividad 4";
            // 
            // Texto
            // 
            this.Texto.Location = new System.Drawing.Point(38, 409);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(328, 20);
            this.Texto.TabIndex = 22;
            this.Texto.TextChanged += new System.EventHandler(this.Texto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Color de texto";
            // 
            // rojo
            // 
            this.rojo.AutoSize = true;
            this.rojo.ForeColor = System.Drawing.Color.Red;
            this.rojo.Location = new System.Drawing.Point(45, 500);
            this.rojo.Name = "rojo";
            this.rojo.Size = new System.Drawing.Size(47, 17);
            this.rojo.TabIndex = 24;
            this.rojo.TabStop = true;
            this.rojo.Text = "Rojo";
            this.rojo.UseVisualStyleBackColor = true;
            this.rojo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // naranja
            // 
            this.naranja.AutoSize = true;
            this.naranja.ForeColor = System.Drawing.Color.OrangeRed;
            this.naranja.Location = new System.Drawing.Point(45, 523);
            this.naranja.Name = "naranja";
            this.naranja.Size = new System.Drawing.Size(62, 17);
            this.naranja.TabIndex = 25;
            this.naranja.TabStop = true;
            this.naranja.Text = "Naranja";
            this.naranja.UseVisualStyleBackColor = true;
            this.naranja.CheckedChanged += new System.EventHandler(this.naranja_CheckedChanged);
            // 
            // azul
            // 
            this.azul.AutoSize = true;
            this.azul.ForeColor = System.Drawing.Color.Blue;
            this.azul.Location = new System.Drawing.Point(45, 546);
            this.azul.Name = "azul";
            this.azul.Size = new System.Drawing.Size(45, 17);
            this.azul.TabIndex = 26;
            this.azul.TabStop = true;
            this.azul.Text = "Azúl";
            this.azul.UseVisualStyleBackColor = true;
            this.azul.CheckedChanged += new System.EventHandler(this.azul_CheckedChanged);
            // 
            // colorFondo
            // 
            this.colorFondo.AutoSize = true;
            this.colorFondo.Location = new System.Drawing.Point(159, 473);
            this.colorFondo.Name = "colorFondo";
            this.colorFondo.Size = new System.Drawing.Size(79, 13);
            this.colorFondo.TabIndex = 27;
            this.colorFondo.Text = "Color de Fondo";
            // 
            // verde
            // 
            this.verde.AutoSize = true;
            this.verde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.verde.Location = new System.Drawing.Point(171, 500);
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(53, 17);
            this.verde.TabIndex = 28;
            this.verde.TabStop = true;
            this.verde.Text = "Verde";
            this.verde.UseVisualStyleBackColor = true;
            this.verde.CheckedChanged += new System.EventHandler(this.verde_CheckedChanged);
            // 
            // morado
            // 
            this.morado.AutoSize = true;
            this.morado.ForeColor = System.Drawing.Color.Purple;
            this.morado.Location = new System.Drawing.Point(171, 523);
            this.morado.Name = "morado";
            this.morado.Size = new System.Drawing.Size(61, 17);
            this.morado.TabIndex = 29;
            this.morado.TabStop = true;
            this.morado.Text = "Morado";
            this.morado.UseVisualStyleBackColor = true;
            this.morado.CheckedChanged += new System.EventHandler(this.morado_CheckedChanged);
            // 
            // rosado
            // 
            this.rosado.AutoSize = true;
            this.rosado.ForeColor = System.Drawing.Color.Fuchsia;
            this.rosado.Location = new System.Drawing.Point(171, 546);
            this.rosado.Name = "rosado";
            this.rosado.Size = new System.Drawing.Size(62, 17);
            this.rosado.TabIndex = 30;
            this.rosado.TabStop = true;
            this.rosado.Text = "Rosado";
            this.rosado.UseVisualStyleBackColor = true;
            this.rosado.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // TamanioFuente
            // 
            this.TamanioFuente.AutoSize = true;
            this.TamanioFuente.Location = new System.Drawing.Point(284, 475);
            this.TamanioFuente.Name = "TamanioFuente";
            this.TamanioFuente.Size = new System.Drawing.Size(82, 13);
            this.TamanioFuente.TabIndex = 31;
            this.TamanioFuente.Text = "Tamaño Fuente";
            // 
            // pequenio
            // 
            this.pequenio.AutoSize = true;
            this.pequenio.Location = new System.Drawing.Point(293, 500);
            this.pequenio.Name = "pequenio";
            this.pequenio.Size = new System.Drawing.Size(48, 17);
            this.pequenio.TabIndex = 32;
            this.pequenio.TabStop = true;
            this.pequenio.Text = "9 PT";
            this.pequenio.UseVisualStyleBackColor = true;
            this.pequenio.CheckedChanged += new System.EventHandler(this.pequenio_CheckedChanged);
            // 
            // mediano
            // 
            this.mediano.AutoSize = true;
            this.mediano.Location = new System.Drawing.Point(293, 523);
            this.mediano.Name = "mediano";
            this.mediano.Size = new System.Drawing.Size(54, 17);
            this.mediano.TabIndex = 33;
            this.mediano.TabStop = true;
            this.mediano.Text = "12 PT";
            this.mediano.UseVisualStyleBackColor = true;
            this.mediano.CheckedChanged += new System.EventHandler(this.mediano_CheckedChanged);
            // 
            // grande
            // 
            this.grande.AutoSize = true;
            this.grande.Location = new System.Drawing.Point(293, 546);
            this.grande.Name = "grande";
            this.grande.Size = new System.Drawing.Size(54, 17);
            this.grande.TabIndex = 34;
            this.grande.TabStop = true;
            this.grande.Text = "15 PT";
            this.grande.UseVisualStyleBackColor = true;
            this.grande.CheckedChanged += new System.EventHandler(this.grande_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1203, 670);
            this.Controls.Add(this.grande);
            this.Controls.Add(this.mediano);
            this.Controls.Add(this.pequenio);
            this.Controls.Add(this.TamanioFuente);
            this.Controls.Add(this.rosado);
            this.Controls.Add(this.morado);
            this.Controls.Add(this.verde);
            this.Controls.Add(this.colorFondo);
            this.Controls.Add(this.azul);
            this.Controls.Add(this.naranja);
            this.Controls.Add(this.rojo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AceptarAct3);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.Femenino);
            this.Controls.Add(this.Ninia);
            this.Controls.Add(this.Ninio);
            this.Controls.Add(this.NombreNiño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.Dog);
            this.Controls.Add(this.Gato);
            this.Controls.Add(this.Perro);
            this.Controls.Add(this.NombreAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.CampoTexto);
            this.Controls.Add(this.TextosAnteriores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox TextosAnteriores;
        private System.Windows.Forms.TextBox CampoTexto;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreAnimal;
        private System.Windows.Forms.CheckBox Perro;
        private System.Windows.Forms.ListBox Gato;
        private System.Windows.Forms.ListBox Dog;
        private System.Windows.Forms.Button Fin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreNiño;
        private System.Windows.Forms.ListBox Ninio;
        private System.Windows.Forms.ListBox Ninia;
        private System.Windows.Forms.RadioButton Femenino;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.Button AceptarAct3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Texto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rojo;
        private System.Windows.Forms.RadioButton naranja;
        private System.Windows.Forms.RadioButton azul;
        private System.Windows.Forms.Label colorFondo;
        private System.Windows.Forms.RadioButton verde;
        private System.Windows.Forms.RadioButton morado;
        private System.Windows.Forms.RadioButton rosado;
        private System.Windows.Forms.Label TamanioFuente;
        private System.Windows.Forms.RadioButton pequenio;
        private System.Windows.Forms.RadioButton mediano;
        private System.Windows.Forms.RadioButton grande;
    }
}

