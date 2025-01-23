using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperacionInterfaces
{
    public partial class controlCaja : UserControl
    {
        private int tamanio = 0;
        static int cont = 0;
        public controlCaja()
        {
            InitializeComponent();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

            lista.SelectedItems.Remove(lista.SelectedItem);

        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el máximo de caracteres que admite el apartado texto")]
        public int maxLengthTextBox
        {
            get
            {

                return texto.MaxLength;
            }

            set
            {

                texto.MaxLength = value;
            }

        }

        [Category("Control personalizado Color")]
        [Description("Este control permite cambiar el color de fondo del slider")]
        Color co = Color.Gray;
        public Color colorSlider
        {
            get
            {

                return co;
            }
            set
            {

                co = value;
                slider.BackColor = co;
            }
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el maximo de elementos que puede tener la lista")]
        public int maxElementosListBox {
            get {

                return tamanio;
            }
            set { 
            
                tamanio = value;
            } 
        }

        EventArgs inser = new EventArgs();
        
        private void insertar(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && texto.Text != "" && lista.Items.Count < tamanio-1)
            {
                cont++;
                lista.Items.Add(texto.Text);
                texto.Text = "";
                slider.Maximum += 1;

            }

            if (cont > tamanio)
            {

                texto.BackColor = Color.Red;
            }
            
            
        }

        private void eliminar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                lista.SelectedItems.Remove(lista.SelectedItem);
            }
        }
    }
}
