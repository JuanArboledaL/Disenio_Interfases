using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Formulario
{

    // I create a class "Persona" that stores the data of the fields
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dirección { get; set; }
        public string FechaNacimiento { get; set; }
    }




    public partial class MainWindow : Window
    {
        private ObservableCollection<Persona> personas = new ObservableCollection<Persona>();

        public MainWindow()
        {
            InitializeComponent();
            Tabla.ItemsSource = personas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombre = NombreTextBox.Text;
            string apellidos = ApellidosTextBox.Text;
            string dirección = DireccionTextBox.Text;
            string fechaNacimiento = FechaNacimientoTextBox.Text;

            // Check that none of the fields are empty
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellidos) && !string.IsNullOrEmpty(dirección) && !string.IsNullOrEmpty(fechaNacimiento))
            {
                personas.Add(new Persona { Nombre = nombre, Apellidos = apellidos, Dirección = dirección, FechaNacimiento = fechaNacimiento });
                // Clear TextBoxes after adding data
                NombreTextBox.Clear();
                ApellidosTextBox.Clear();
                DireccionTextBox.Clear();
                FechaNacimientoTextBox.Clear();
            }
            else
            {
                // If it is empty, it sends an error message
                MessageBox.Show("Por favor, completa todos los campos antes de agregar.");
            }
        }
    }
}
