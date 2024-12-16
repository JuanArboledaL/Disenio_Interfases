using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void CampoTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextosAnteriores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            
            TextosAnteriores.Items.Add(CampoTexto.Text);
            CampoTexto.Text = "";
        }


        private void Gato_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NombreAnimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Perro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gato_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Fin_Click(object sender, EventArgs e)
        {
            if (Perro.Checked == true)
            {
                Dog.Items.Add(NombreAnimal.Text);
                
            }
            else {

                Gato.Items.Add(NombreAnimal.Text);
            }

            NombreAnimal.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Masculino_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Ninia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AceptarAct3_Click(object sender, EventArgs e)
        {
            if (Femenino.Checked == true)
            {

                Ninia.Items.Add(NombreNiño.Text);
            }
            else if (Masculino.Checked == true) {

                Ninio.Items.Add(NombreNiño.Text);

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             Texto.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Texto.BackColor = Color.Pink;
        }

        private void Texto_TextChanged(object sender, EventArgs e)
        {

        }

        private void naranja_CheckedChanged(object sender, EventArgs e)
        {
            Texto.ForeColor = Color.Orange;
        }

        private void azul_CheckedChanged(object sender, EventArgs e)
        {
            Texto.ForeColor = Color.Blue;
        }

        private void verde_CheckedChanged(object sender, EventArgs e)
        {
            Texto.BackColor = Color.Green;
        }

        private void morado_CheckedChanged(object sender, EventArgs e)
        {
            Texto.BackColor = Color.Purple;
        }

        private void pequeño_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void mediano_CheckedChanged(object sender, EventArgs e)
        {
            Texto.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);

        }

        private void pequenio_CheckedChanged(object sender, EventArgs e)
        {
            Texto.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
        }

        private void grande_CheckedChanged(object sender, EventArgs e)
        {
            Texto.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 15, FontStyle.Regular);

        }
    }
}
