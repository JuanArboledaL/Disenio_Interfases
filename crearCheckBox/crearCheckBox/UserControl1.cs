using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace crearCheckBox
{
    public partial class UserControl1 : UserControl
    {
        [Category("ajustes del componente")]
        [Description("Cambiar máxima logitud de el texto que se va a ingresar")]
        public int maxLength
        {

            get
            {

                return ingresarTexto.MaxLength;
            }

            set
            {

                ingresarTexto.MaxLength = value;
                cantCaracteres.Text = "0/" + maxLength;
            }

        }


        public enum posicion{
        
            Arriba,
            Abajo
        }

        private posicion pos;

        [Category("ajustes del componente")]
        [Description("Cambiar el nombre de el label")]

        public string cambiarLabel
        {

            
            set
            {
                label1.Text = value;

                int tamanio = value.Length;

                if (tamanio > 6) { 
                
                }
            }

            get {

                return label1.Text;
            }

        }

        [Category("ajustes del componente")]
        [Description("Cambiar la ubicación del label")]

        public posicion cambiarUbicacion {

            get {

                return pos;
            }

            set {

                pos = value;

                if (value == posicion.Abajo) { 

                    this.label1.Location = new Point(3, 28);
                    Size = new Size(198, 45);
                    this.cantCaracteres.Location = new Point(168, 9);
                    this.ingresarTexto.Location = new Point(35, 25);

                }
                else if(value == posicion.Arriba){

                    this.label1.Location = new Point(3, 9);
                    Size = new Size(165, 45);
                    this.cantCaracteres.Location = new Point(131, 9);
                    this.ingresarTexto.Location = new Point(3, 25);

                }
                
            }  
        
        }


        public UserControl1()
        {
            InitializeComponent();

            this.label1.Location = new Point(3, 9);
            Size = new Size(165, 45);
            this.cantCaracteres.Location = new Point(131, 9);
            this.ingresarTexto.Location = new Point(3, 25);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        
        private void ingresarTexto_TextChanged(object sender, EventArgs e)
        {
            int cantidad = ingresarTexto.Text.Length;

            cantCaracteres.Text= cantidad + "/" + maxLength;

        }

    }
}
