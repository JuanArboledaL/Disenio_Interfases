using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace foto
{
    public partial class foto: UserControl
    {
        private OpenFileDialog openFileDialog1;
        private string fileContent;

        [Category("ajustes")]
        [Description("Cambia el texto que aparece en la parte inferior de la foto")]
        public string cambiarPieDeFoto {
            

            get {

                return pieDeFoto.Text;

            }

            set { 
            
                pieDeFoto.Text = value;

            } 
        }

        private Image img;
        [Category("ajustes")]
        [Description("Cambia la imagen")]
        public Image cambiarImagen
        {

            get
            {

                return null;
            }
            set
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "imágenes files (*.jpg)|*.jpg|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
        
        [Category("ajustes")]
        [Description("Cambia el tamanio del texto")]
        public float tamanioTexto
        {
            get
            {

                return pieDeFoto.Font.Size;
            }
            set
            {

                pieDeFoto.Font = new Font("Sans",value,FontStyle.Regular);
            }
        }

        public foto()
        {
            InitializeComponent();
            pieDeFoto.Text = "Ingresa el pie de foto";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
