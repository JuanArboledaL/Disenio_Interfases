﻿namespace InsertarElement
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
            this.userControl11 = new crearCheckBox.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.cambiarLabel = "label1";
            this.userControl11.cambiarUbicacion = crearCheckBox.UserControl1.posicion.arriba;
            this.userControl11.Location = new System.Drawing.Point(189, 137);
            this.userControl11.maxLength = 10;
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(165, 45);
            this.userControl11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private crearCheckBox.UserControl1 userControl11;
    }
}

