namespace RecuperacionInterfaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buscar = new System.Windows.Forms.Button();
            this.palabraMaslarga = new System.Windows.Forms.TextBox();
            this.controlCaja1 = new RecuperacionInterfaces.controlCaja();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscar.Location = new System.Drawing.Point(388, 123);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(137, 33);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "button1";
            this.buscar.UseVisualStyleBackColor = false;
            // 
            // palabraMaslarga
            // 
            this.palabraMaslarga.Location = new System.Drawing.Point(388, 97);
            this.palabraMaslarga.Name = "palabraMaslarga";
            this.palabraMaslarga.Size = new System.Drawing.Size(136, 20);
            this.palabraMaslarga.TabIndex = 2;
            // 
            // controlCaja1
            // 
            this.controlCaja1.colorSlider = System.Drawing.Color.Gray;
            this.controlCaja1.Location = new System.Drawing.Point(114, 124);
            this.controlCaja1.maxElementosListBox = 6;
            this.controlCaja1.maxLengthTextBox = 5;
            this.controlCaja1.MinimumSize = new System.Drawing.Size(206, 225);
            this.controlCaja1.Name = "controlCaja1";
            this.controlCaja1.Size = new System.Drawing.Size(206, 225);
            this.controlCaja1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImageLocation = "donJuan.png";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 131);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.controlCaja1);
            this.Controls.Add(this.palabraMaslarga);
            this.Controls.Add(this.buscar);
            this.Name = "Form1";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox palabraMaslarga;
        private controlCaja controlCaja1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

