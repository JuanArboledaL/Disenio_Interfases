using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicar
{
    public partial class Form1 : Form
    {
        private int cont;
        public Form1()
        {
            InitializeComponent();
            cont = 0;
        }

        private void cronometro1_obtenerSegundos_1(object sender, EventArgs e)
        {
            cont++;

            if (cont == 100) {

                cont = 0;
                var date = DateTime.Now;
                dataGridView1.Rows.Add(date.Hour.ToString(), date.Minute.ToString(), date.Second.ToString());
            }
            
        }
    }
}
