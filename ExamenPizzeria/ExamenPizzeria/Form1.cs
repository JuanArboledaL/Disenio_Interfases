using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPizzeria
{
    public partial class Form1 : Form
    {
        private List<Ingredientes> ingre1;
        private List<Ingredientes> ingre2;
        private List<Ingredientes> ingre3;
        private List<Ingredientes> ingre4;
        private List<Ingredientes> ingre5; 
        private List<Ingredientes> ingre6;
        private List<Ingredientes> ingre7;
        private List<Ingredientes> ingre8;
        private List<Ingredientes> ingre9;
        private List<Ingredientes> ingre10;
        private List<Bebidas> b1;
        private List<Bebidas> b2;
        private List<Bebidas> b3;
        private List<Bebidas> b4;
        private List<Bebidas> b5;
        private List<Bebidas> b6;
        private List<Bebidas> b7;
        private List<Postres> p1;
        private List<Postres> p2;
        private List<Postres> p3;
        private List<Postres> p4;
        private List<Postres> p5;
        private int pizzaGrande = 15;
        private int pizzaMediana = 10;
        private int pizzaPequenia = 8;
        private int cantIngredientes=0;
        private int precioIngrediente;

        public Form1()
        {
            InitializeComponent();
        }
       
        //Cargar ingredientes
        public void cargarDatos() {

            ingre1 = new List<Ingredientes> { new Ingredientes("Peproni", 2 )};
            ingre2 = new List<Ingredientes> { new Ingredientes("Queso azul", 2) };
            ingre3 = new List<Ingredientes> { new Ingredientes("Burrata", 2) };
            ingre4 = new List<Ingredientes> { new Ingredientes("Pistachos", 2) };
            ingre5 = new List<Ingredientes> { new Ingredientes("Cebolla", 2) };
            ingre6 = new List<Ingredientes> { new Ingredientes("Jamón Serrano", 2) };
            ingre7 = new List<Ingredientes> { new Ingredientes("Champiñones", 2) };
            ingre8 = new List<Ingredientes> { new Ingredientes("Tomate", 2) };
            ingre9 = new List<Ingredientes> { new Ingredientes("Alcachofa", 2) };
            ingre10 = new List<Ingredientes> { new Ingredientes("Piña", 2) };

            b1 = new List<Bebidas> { new Bebidas("Coca-cola (normal)",3) };
            b2 = new List<Bebidas> { new Bebidas("Coca-cola (Cero)", 3)};
            b3 = new List<Bebidas> { new Bebidas("Agua", 2) };
            b4 = new List<Bebidas> { new Bebidas("Cerveza", 3) };
            b5 = new List<Bebidas> { new Bebidas("Tinto de de Verano", 4) };
            b6 = new List<Bebidas> { new Bebidas("Fanta", 3) };
            b7 = new List<Bebidas> { new Bebidas("Aquarius", 3) };

            p1 = new List<Postres> { new Postres("Tarta de queso", 5) };
            p2 = new List<Postres> { new Postres("Tarta de chocolate", 5) };
            p3 = new List<Postres> { new Postres("Arroz con leche", 4) };
            p4 = new List<Postres> { new Postres("Natilla", 4) };
            p5 = new List<Postres> { new Postres("Flan", 4) };

        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            cargarDatos();
        }
       
        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void preciosProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pGrandre_Click(object sender, EventArgs e)
        {
            preciosProductos.Rows.Add(pizzaGrande.ToString());
        }

        private void pMediana_Click(object sender, EventArgs e)
        {
            preciosProductos.Rows.Add(pizzaMediana.ToString());
        }

        private void pPequeña_Click(object sender, EventArgs e)
        {
            preciosProductos.Rows.Add(pizzaPequenia.ToString());
        }

        private void agregarIngrediente_Click(object sender, EventArgs e)
        {
            List<String> todos = new List<String>();

            foreach (int i in Ingredientes.SelectedIndices)
            {

                todos.Add(Ingredientes.Items[i].ToString());

            }

            cantIngredientes = todos.Count;

            precioIngrediente = cantIngredientes * 2;
            preciosProductos.Rows.Add(precioIngrediente.ToString());

            foreach (DataGridViewRow row in preciosProductos.Rows)
            {
                row.Cells[1].Value = Convert.ToString(precioIngrediente);
            }

        }


    }
}
