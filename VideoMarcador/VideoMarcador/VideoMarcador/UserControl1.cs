using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace VideoMarcador
{
    public partial class videoMarcador: UserControl
    {
        public videoMarcador()
        {
            InitializeComponent();
        }

        public event EventHandler Goles;
        public event EventHandler partePartido;


        public void GolesDerecha() { 
        
            Goles?.Invoke(this, EventArgs.Empty);
           
            cantidadGolesDe.Text = Goles.Target.ToString();
        }

        [Category("Ajustes del VideoMarcador")]
        [Description("Modifica si estamos en la primera o segunda parte")]
        public String numeroDeLaParte
        {

            get
            {

                return parte.Text;
            }
            set
            {
                parte.Text = value;
            }
        }


        [Category("Ajustes del VideoMarcador")]
        [Description("Modifica el nombre del equipo 1 (izquierda)")]
        public string nombreEquipo1izquierda {
            
            get {

                return equipo1izquierda.Text;
            }
            set {

                equipo1izquierda.Text = value;
            }
        }

        [Category("Ajustes del VideoMarcador")]
        [Description("Modifica el nombre del equipo 2 (derecha)")]
        public string nombreEquipo2derecha
        {

            get
            {

                return equipo2derecha.Text;
            }
            set
            {

                equipo2derecha.Text = value;
            }
        }

        

    }
}
