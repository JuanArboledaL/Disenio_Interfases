using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPersona
{
    public partial class Form1 : Form
    {

        DatosPersonales dp = new DatosPersonales();
        private static List<String> hijos;
        private static List<DatosPersonales> listaPersonas = new List<DatosPersonales>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Modificar los datos del usuario
        private void modificar_Click(object sender, EventArgs e)
        {

            nombre.Text = registroDatos.CurrentRow.Cells[0].Value.ToString();
            apellido.Text = registroDatos.CurrentRow.Cells[1].Value.ToString();
            direccion.Text = registroDatos.CurrentRow.Cells[2].Value.ToString();
            telefono.Text = registroDatos.CurrentRow.Cells[3].Value.ToString();


        }

        //Evaluar si tiene o no hijos el usuario
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                campoHijos.Enabled = true;
            }
            else
            {

                campoHijos.Enabled = false;
            }
        }

        private void nombreHijos_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void hijosAgregados_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        //Añadir los hijos en el treeView 
        private void nombresHijos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (hijosAgregados.Nodes.Count == 0)
                {

                    hijos.Add(nombre.Text);
                    hijosAgregados.Nodes.Add(nombre.Text);
                }


                if (dp.getHijos().Count < cantidadHijos.Value)
                {

                    hijosAgregados.Nodes[0].Nodes.Add(nombreHijos.Text);

                    dp.anadirHijo(nombreHijos.Text);
                    dp.anadirHijos(hijos);

                    nombreHijos.Clear();
                }
                else
                {

                    errorProvider1.SetError(this.nombreHijos, "Ha ingresado el máximo de hijos");
                }

                hijosAgregados.ExpandAll();
            }
        }


        //Agregar los datos en el registro
        private void aceptar_Click_1(object sender, EventArgs e)
        {


            if (!checkBox1.Checked)
            {

                listaPersonas.Add(new DatosPersonales(nombre.Text, apellido.Text, direccion.Text, telefono.Text, 0));


                registroDatos.Rows.Add(nombre.Text, apellido.Text, direccion.Text, telefono.Text, 0);

                nombre.Clear();
                apellido.Clear();
                direccion.Clear();
                telefono.Clear();
                checkBox1.Checked = false;
            }
            else
            {

                listaPersonas.Add(new DatosPersonales(nombre.Text, apellido.Text, direccion.Text, telefono.Text, cantidadHijos.Value));

                registroDatos.Rows.Add(nombre.Text, apellido.Text, direccion.Text, telefono.Text, cantidadHijos.Value);

                dp.anadirHijo(nombreHijos.Text);
                nombre.Clear();
                apellido.Clear();
                direccion.Clear();
                telefono.Clear();
                nombreHijos.Clear();
                cantidadHijos.Value = 1;
                checkBox1.Checked = false;
                hijosAgregados.Nodes.Clear();

            }

            errorProvider1.SetError(this.nombreHijos, null);

        }
    }
}
