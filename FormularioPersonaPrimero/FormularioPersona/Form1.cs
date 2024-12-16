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
        List<datosPersonales> datosPersonales = new List<datosPersonales>();
        datosPersonales dp;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label6_Click_1(object sender, EventArgs e)
        {

        }
        
        //Evaluar si tiene o no hijos el usuario
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                campoHijos.Enabled = true;
            }
            else {
            
                campoHijos.Enabled=false;
            }
        }

        //Agregar los datos en el registro
        private void aceptar_Click(object sender, EventArgs e)
        {

            if (!checkBox1.Checked)
            {

                datosPersonales.Add( new datosPersonales(nombre.Text,apellido.Text,direccion.Text,telefono.Text,0));

                registroDatos.Rows.Add(nombre.Text, apellido.Text,direccion.Text,telefono.Text, 0);
                nombre.Clear();
                apellido.Clear();
                direccion.Clear();
                telefono.Clear();
                checkBox1.Checked= false;
            }
            else {
                
                datosPersonales.Add( new datosPersonales(nombre.Text, apellido.Text, direccion.Text, telefono.Text, cantidadHijos.Value));

                registroDatos.Rows.Add(nombre.Text, apellido.Text, direccion.Text, telefono.Text, cantidadHijos.Value);
                dp.anadirHijo(nombreHijos.Text);
                nombre.Clear();
                apellido.Clear();
                direccion.Clear();
                telefono.Clear();
                nombreHijos.Clear();
                cantidadHijos.Value = 1;
                checkBox1.Checked = false;

            }
        }

        private void hijosAgregados_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidadHijos_Scroll(object sender, EventArgs e)
        {
            
        }

        private void nombreHijos_TextChanged(object sender, EventArgs e)
        {

        }

        //Añadir los hijos en el treeView 
        private void nombreHijos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TreeNode padre = new TreeNode(nombre.Text);

               // if ((dp.getHijos().Count) == cantidadHijos.Value) {

                    //dp.anadirHijo(nombreHijos.Text);//Añadir hijos a la lista que esta en la clase persona

                    padre.Nodes.Add(nombreHijos.Text);

                    hijosAgregados.Nodes[0] = padre.Nodes.Add(nombreHijos.Text);

                //}

            }
        }

        private void registroDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
