namespace ProyectoAuto
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
            this.nombreMarca = new System.Windows.Forms.Label();
            this.modeloCoches = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagenesDeLosModelos = new System.Windows.Forms.PictureBox();
            this.Adicionales = new System.Windows.Forms.ListBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.seleccionados = new System.Windows.Forms.ListBox();
            this.quitar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FechaEntrega = new System.Windows.Forms.Label();
            this.numPuertas = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.codDescuento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigosAgregados = new System.Windows.Forms.ListBox();
            this.eliminarCodigo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesDeLosModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreMarca
            // 
            this.nombreMarca.AutoSize = true;
            this.nombreMarca.BackColor = System.Drawing.Color.Transparent;
            this.nombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 57.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreMarca.Location = new System.Drawing.Point(215, 19);
            this.nombreMarca.Name = "nombreMarca";
            this.nombreMarca.Size = new System.Drawing.Size(359, 87);
            this.nombreMarca.TabIndex = 0;
            this.nombreMarca.Text = "TOYOTA";
            this.nombreMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // modeloCoches
            // 
            this.modeloCoches.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.modeloCoches.DisplayMember = "rfefr";
            this.modeloCoches.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modeloCoches.FormattingEnabled = true;
            this.modeloCoches.Items.AddRange(new object[] {
            "Land Cruiser Prado",
            "Yaris",
            "Corolla",
            "C-HR",
            "4RUNNER",
            "GT86"});
            this.modeloCoches.Location = new System.Drawing.Point(356, 163);
            this.modeloCoches.Name = "modeloCoches";
            this.modeloCoches.Size = new System.Drawing.Size(218, 21);
            this.modeloCoches.TabIndex = 1;
            this.modeloCoches.Tag = "";
            this.modeloCoches.SelectedIndexChanged += new System.EventHandler(this.modeloCoches_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\ProyectoAuto\\toyota.png";
            this.pictureBox1.Location = new System.Drawing.Point(561, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // imagenesDeLosModelos
            // 
            this.imagenesDeLosModelos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagenesDeLosModelos.Location = new System.Drawing.Point(215, 381);
            this.imagenesDeLosModelos.Name = "imagenesDeLosModelos";
            this.imagenesDeLosModelos.Size = new System.Drawing.Size(478, 151);
            this.imagenesDeLosModelos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenesDeLosModelos.TabIndex = 2;
            this.imagenesDeLosModelos.TabStop = false;
            this.imagenesDeLosModelos.Click += new System.EventHandler(this.imagenesDeLosModelos_Click);
            // 
            // Adicionales
            // 
            this.Adicionales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Adicionales.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Adicionales.FormattingEnabled = true;
            this.Adicionales.Location = new System.Drawing.Point(215, 226);
            this.Adicionales.Name = "Adicionales";
            this.Adicionales.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Adicionales.Size = new System.Drawing.Size(186, 95);
            this.Adicionales.TabIndex = 4;
            this.Adicionales.SelectedIndexChanged += new System.EventHandler(this.Adicionales_SelectedIndexChanged);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(419, 226);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // seleccionados
            // 
            this.seleccionados.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.seleccionados.FormattingEnabled = true;
            this.seleccionados.Location = new System.Drawing.Point(512, 226);
            this.seleccionados.Name = "seleccionados";
            this.seleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.seleccionados.Size = new System.Drawing.Size(181, 95);
            this.seleccionados.TabIndex = 6;
            this.seleccionados.SelectedIndexChanged += new System.EventHandler(this.seleccionados_SelectedIndexChanged);
            // 
            // quitar
            // 
            this.quitar.Location = new System.Drawing.Point(419, 298);
            this.quitar.Name = "quitar";
            this.quitar.Size = new System.Drawing.Size(75, 23);
            this.quitar.TabIndex = 7;
            this.quitar.Text = "Quitar";
            this.quitar.UseVisualStyleBackColor = true;
            this.quitar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 577);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 10, 2, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.AutoSize = true;
            this.FechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEntrega.ForeColor = System.Drawing.Color.Black;
            this.FechaEntrega.Location = new System.Drawing.Point(212, 559);
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Size = new System.Drawing.Size(225, 15);
            this.FechaEntrega.TabIndex = 9;
            this.FechaEntrega.Text = "Fecha en la que desea su entrega";
            this.FechaEntrega.Click += new System.EventHandler(this.FechaEntrega_Click);
            // 
            // numPuertas
            // 
            this.numPuertas.AutoSize = true;
            this.numPuertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPuertas.ForeColor = System.Drawing.Color.Black;
            this.numPuertas.Location = new System.Drawing.Point(212, 355);
            this.numPuertas.Name = "numPuertas";
            this.numPuertas.Size = new System.Drawing.Size(147, 16);
            this.numPuertas.TabIndex = 10;
            this.numPuertas.Text = "Cantidad de puertas";
            this.numPuertas.Click += new System.EventHandler(this.numPuertas_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(365, 355);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // codDescuento
            // 
            this.codDescuento.AcceptsTab = true;
            this.codDescuento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.codDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.codDescuento.Location = new System.Drawing.Point(212, 643);
            this.codDescuento.MaxLength = 5;
            this.codDescuento.Name = "codDescuento";
            this.codDescuento.Size = new System.Drawing.Size(203, 20);
            this.codDescuento.TabIndex = 13;
            this.codDescuento.TextChanged += new System.EventHandler(this.codDescuento_TextChanged);
            this.codDescuento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codDescuento_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(212, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingresa un código promocional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(214, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "(Solo se admiten 5 caracteres alfabeticos)";
            // 
            // codigosAgregados
            // 
            this.codigosAgregados.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.codigosAgregados.FormattingEnabled = true;
            this.codigosAgregados.Location = new System.Drawing.Point(541, 640);
            this.codigosAgregados.Name = "codigosAgregados";
            this.codigosAgregados.Size = new System.Drawing.Size(152, 69);
            this.codigosAgregados.TabIndex = 16;
            this.codigosAgregados.SelectedIndexChanged += new System.EventHandler(this.codigosAgregados_SelectedIndexChanged);
            this.codigosAgregados.Enter += new System.EventHandler(this.codigosAgregados_SelectedIndexChanged);
            // 
            // eliminarCodigo
            // 
            this.eliminarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarCodigo.ForeColor = System.Drawing.Color.Black;
            this.eliminarCodigo.Location = new System.Drawing.Point(541, 715);
            this.eliminarCodigo.Name = "eliminarCodigo";
            this.eliminarCodigo.Size = new System.Drawing.Size(77, 30);
            this.eliminarCodigo.TabIndex = 17;
            this.eliminarCodigo.Text = "Eliminar";
            this.eliminarCodigo.UseVisualStyleBackColor = true;
            this.eliminarCodigo.Click += new System.EventHandler(this.eliminarCodigo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(405, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Elige el modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(214, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Adicionales para tu vehiculo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(516, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Adicionales seleccionados";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.errorProvider1_RightToLeftChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(538, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Códigos añadidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(877, 839);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eliminarCodigo);
            this.Controls.Add(this.codigosAgregados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codDescuento);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numPuertas);
            this.Controls.Add(this.FechaEntrega);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.quitar);
            this.Controls.Add(this.seleccionados);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Adicionales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imagenesDeLosModelos);
            this.Controls.Add(this.modeloCoches);
            this.Controls.Add(this.nombreMarca);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesDeLosModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreMarca;
        private System.Windows.Forms.ComboBox modeloCoches;
        private System.Windows.Forms.PictureBox imagenesDeLosModelos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Adicionales;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.ListBox seleccionados;
        private System.Windows.Forms.Button quitar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FechaEntrega;
        private System.Windows.Forms.Label numPuertas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox codDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox codigosAgregados;
        private System.Windows.Forms.Button eliminarCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
    }
}

