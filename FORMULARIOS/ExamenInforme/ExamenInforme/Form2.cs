using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenInforme
{
    public partial class Form2 : Form
    {
        public string zona;
        
        public Form2()
        {
            InitializeComponent();
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void examinar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";

            openFileDialog1.Filter = "Archivos Csv (*.csv)|* .csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string str_rutaArchivo = openFileDialog1.FileName;
                    rutaArchivo.Text = str_rutaArchivo;
                }
                catch { 
                

                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ciudadesGrandes = ciudadesGrandes.Checked;
            form1.archivo = rutaArchivo.Text;
            form1.nombreCiudad = zona; ;
            form1.zonaHoria = zonaHoraria.SelectedIndex.ToString();
            form1.ShowDialog();
        }

        private void zonaHoraria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (zonaHoraria.SelectedItem) { 
            
                case 0:
                    zona += "Ameria/New_York";
                    break;
                case 1:
                    zona+= "America/Los_Angeles";
                    break;
                case 2:
                    zona += "America/Chicago";
                    break;
            }
        }
    }
}
