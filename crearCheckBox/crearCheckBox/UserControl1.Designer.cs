namespace crearCheckBox
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ingresarTexto = new System.Windows.Forms.TextBox();
            this.cantCaracteres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ingresarTexto
            // 
            this.ingresarTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingresarTexto.Location = new System.Drawing.Point(6, 25);
            this.ingresarTexto.MaxLength = 50;
            this.ingresarTexto.Name = "ingresarTexto";
            this.ingresarTexto.Size = new System.Drawing.Size(157, 20);
            this.ingresarTexto.TabIndex = 1;
            this.ingresarTexto.TextChanged += new System.EventHandler(this.ingresarTexto_TextChanged);
            // 
            // cantCaracteres
            // 
            this.cantCaracteres.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cantCaracteres.AutoSize = true;
            this.cantCaracteres.Location = new System.Drawing.Point(134, 9);
            this.cantCaracteres.Name = "cantCaracteres";
            this.cantCaracteres.Size = new System.Drawing.Size(30, 13);
            this.cantCaracteres.TabIndex = 2;
            this.cantCaracteres.Text = "0/50";
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cantCaracteres);
            this.Controls.Add(this.ingresarTexto);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(0, 49);
            this.MinimumSize = new System.Drawing.Size(163, 49);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(163, 49);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingresarTexto;
        private System.Windows.Forms.Label cantCaracteres;
    }
}
