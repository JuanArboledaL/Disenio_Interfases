using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TermometroPrimerElemento.Properties;

namespace TermometroPrimerElemento
{
    public partial class Termometro: UserControl
    {
        public Termometro()
        {
            InitializeComponent();
        }

        private void Termometro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 1)
            {

                pictureBox1.Image = Resources.frio;
            }
            else if (trackBar1.Value == 2) {

                pictureBox1.Image = Resources.normal;
            }
            else
            {
                pictureBox1.Image = Resources.calor;
            }
        }

        [Category("ajustes")]
        public int Cachopo {

            get {

                
                return trackBar1.Value; ;
            }


            set {

                if (value < 10 && value > 0) {

                    trackBar1.Value = value;
                    pictureBox1.Image = Resources.img;

                    if (trackBar1.Value == 1)
                    {

                        pictureBox1.Image = Resources.frio;
                    }
                    else if (trackBar1.Value == 2)
                    {

                        pictureBox1.Image = Resources.normal;
                    }
                    else
                    {
                        pictureBox1.Image = Resources.calor;
                    }
                }

            } 
          
        }

        

        public event EventHandler ThresholdReached;
        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            handler?.Invoke(this, e);

        }

    }
}
