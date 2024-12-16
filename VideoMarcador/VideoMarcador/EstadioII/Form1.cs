using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadioII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void golesIzquierdo_Scroll(object sender, EventArgs e)
        {

        }

        private void videoMarcador1_Goles(object sender, EventArgs e)
        {
            golesDerecha.ToString();
            
        }
        

        private void videoMarcador1_partePartido(object sender, EventArgs e)
        {
           
            videoMarcador1_partePartido((ComboBox)sender, e);
        }
    }
}
