using formAutoGrid.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formAutoGrid
{
    public partial class Form1 : Form
    {
        Extras Extras ;
        private List<Extras> mod1;
        private List<Extras> mod2;
        private List<Extras> mod3;
        private List<Extras> mod4;
        private List<Extras> mod5;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imagenesCoches_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void aniadir_Click_1(object sender, EventArgs e)
        {

            if (Adicionales.SelectedItems.Count > 0) {


                List<Extras> todos = new List<Extras>();

                foreach (Extras i in Adicionales.SelectedIndices)
                {
                    todos.Add(i);
                    //milista.where(x => x.nombre.equals("radio"));
                }

                foreach (Extras a in todos)
                {
                    dataGridView1.Rows.Add(todos);

                }

            }
            
        }

        private void picturCar_Click_2(object sender, EventArgs e)
        {

        }

        private void modelosCoche_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            switch (modelosCoche.SelectedIndex)
            {

                case 0:
                    picturCar.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\formAutoGrid\\scalade.png";
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod1.ToArray());
                    break;

                case 1:
                    picturCar.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\formAutoGrid\\clase62.png";
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod2.ToArray());
                    break;
                case 2:
                    picturCar.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\formAutoGrid\\cts.png";
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod3.ToArray());
                    break;
                case 3:
                    picturCar.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\formAutoGrid\\cts2016.png";
                    Adicionales.Items.Clear();
                    //Adicionales.Items.Add(Extras.;
                    Adicionales.Items.AddRange(mod4.ToArray());
                    break;
                case 4:
                    picturCar.ImageLocation = "C:\\Users\\Juanito\\source\\repos\\formAutoGrid\\ct62018.png";
                    Adicionales.Items.Clear();
                    Adicionales.Items.AddRange(mod5.ToArray());
                    break;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Adicionales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargar()
        {

            mod1 = new List<Extras>() { new Extras("Audio Bose: ", 1500), new Extras("Bizona: ", 100), new Extras("Cámara trasera: ", 200), new Extras("Sensores: ", 200) };

            mod2 = new List<Extras>(mod1) { new Extras("Control de cambio lateral: ", 300), new Extras("Control de velocidad", 400) };

            mod3 = new List<Extras>(mod2) { new Extras("GPS: ", 200), new Extras("Llanta 18 pulgadas: ", 1500), new Extras("Asistencia de aparcamiento", 200), new Extras("Automatico", 500) };

            mod4 = new List<Extras>(mod3) { new Extras("Andoid auto: ", 500), new Extras("Cr7 como copiloto: ", 20000)};

            mod5 = new List<Extras>(mod4) { new Extras("Frenos ABS:  ",2000), new Extras("Aistencia de manejo: ",1000 )};
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numPuertas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void financiacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
    }
