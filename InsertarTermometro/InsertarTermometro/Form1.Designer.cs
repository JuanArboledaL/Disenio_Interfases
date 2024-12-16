namespace InsertarTermometro
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
            this.cronometro1 = new Crono.cronometro();
            this.SuspendLayout();
            // 
            // cronometro1
            // 
            this.cronometro1.colorNumeros = System.Drawing.Color.Empty;
            this.cronometro1.Location = new System.Drawing.Point(108, 69);
            this.cronometro1.MinimumSize = new System.Drawing.Size(377, 169);
            this.cronometro1.Name = "cronometro1";
            this.cronometro1.Size = new System.Drawing.Size(759, 434);
            this.cronometro1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 628);
            this.Controls.Add(this.cronometro1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Crono.cronometro cronometro1;
    }
}

