using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLEGARA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingredientes(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
            
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void anaPizza_Click(object sender, EventArgs e)
        {
            string pizza = "";
            int precio=0;
            string ingredientes;

            switch (comboBox1.SelectedIndex) { 
            
                case 0: pizza = "Pequeña";
                    precio = 8;
                    break;
                case 1: pizza = "Mediana";
                    precio = 10;
                    break;
                case 2: pizza = "Grande";
                    precio = 15;
                    break;
            }

            foreach (string ingredientes in listBox1.Items) { 
            
                ingredientes += " "ingredientes;
            }

            dataGridView1.Rows.Add(pizza,ingredientes,precio);
        }
    }
}
