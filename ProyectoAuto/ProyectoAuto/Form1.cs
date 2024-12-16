using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoAuto
{
    public partial class Form1 : Form
    {

        private List<String> mod1;
        private List<String> mod2;
        private List<String> mod3;
        private List<String> mod4;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modeloCoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modeloCoches.SelectedIndex) {

                case 0: imagenesDeLosModelos.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\ProyectoAuto\\prado.png";
                    seleccionados.Items.Clear();
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod1.ToArray());
                    break;
                case 1: imagenesDeLosModelos.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\ProyectoAuto\\yaris.png";
                    seleccionados.Items.Clear();
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod2.ToArray());
                    break;
                case 2:
                    imagenesDeLosModelos.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\ProyectoAuto\\coro.png";
                    seleccionados.Items.Clear();
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod3.ToArray());
                    break;
                case 3:
                    imagenesDeLosModelos.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\ProyectoAuto\\ch.png";
                    seleccionados.Items.Clear();
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod4.ToArray());
                    break;
                case 4: imagenesDeLosModelos.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\ProyectoAuto\\runner.png";
                    seleccionados.Items.Clear();
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod4.ToArray());
                    break;
                case 5: imagenesDeLosModelos.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\ProyectoAuto\\gt.png";
                    seleccionados.Items.Clear();
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod4.ToArray());
                    break;
            }

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void imagenesDeLosModelos_Click(object sender, EventArgs e)
        {

        }

        private void Adicionales_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cargar() {

            mod1 = new List<String>() { "Audio Bose", "Bizona", "Cámara trasera", "Sensores" };

            mod2 = new List<String>(mod1) { "Control de cambio lateral", "Control de velocidad," };

            mod3 = new List<String>(mod2) { "GPS", "llanta 18 pulgadas", "Asistencia aparcamiento", "Automatico" };

            mod4 = new List<String>(mod3) { "Andoid auto", "Cr7 como copiloto" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seleccionados.Items.Remove(seleccionados.Text);
        }

        private void seleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
           List<String> todos = new List<String>();

            foreach (int i in Adicionales.SelectedIndices)
            {

                todos.Add(Adicionales.Items[i].ToString());
                Adicionales.Items.RemoveAt(i);

            }

            foreach (String a in todos) { 
            
                seleccionados.Items.Add(a);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FechaEntrega_Click(object sender, EventArgs e)
        {

        }

        private void numPuertas_Click(object sender, EventArgs e)
        {

        }

        private void codDescuento_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void codigosAgregados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void codDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {

          

        }

        private void eliminarCodigo_Click(object sender, EventArgs e)
        {

            codigosAgregados.Items.Remove(codigosAgregados.Text);   
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void codDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (codDescuento.Text.Length == 5 && codigosAgregados.Items.Count < 3)
                {
                    codigosAgregados.Items.Add(codDescuento.Text);
                    codDescuento.Clear();
                }
            }
            else
            {

                if (codDescuento.Text.Length < 4)
                {


                    errorProvider1.SetError(this.codDescuento, "Tienen que ser 5 caracteres");
                }
                else
                {

                    errorProvider1.SetError(this.codDescuento, null);
                }

            }
            if (codigosAgregados.Items.Count == 3)
            {

                ErrorProvider errorProvider2 = new ErrorProvider();
                errorProvider2.SetError(this.codigosAgregados, "Has completado el máximo de códigos promocionales");

            }
        }
    }
}
