using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RevolucionesCocheWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean interruptor = false;
        private int revoluciones;
        public MainWindow()
        {
            InitializeComponent();
            RotateTransform transform = new RotateTransform();
            
        }

        private void acelerador_Click(object sender, RoutedEventArgs e)
        {
            if (interruptor == true) {

                if (sport.IsChecked == true)
                {
                   
                    modSport();
                }
                else if (modEco.IsChecked == true)
                {

                    eco();
                }
                else { 
                
                    normal();
                }
            }
        }

        private void freno_Click(object sender, RoutedEventArgs e)
        {
            if (interruptor == true) {

                if (rotarAguja.Angle > 0) {

                    if (rotarAguja.Angle < 0)
                    {
                        rotarAguja.Angle = 0;
                        velocimetro.Content ="0/Km";
                    }
                    else {

                        rotarAguja.Angle = rotarAguja.Angle - 10;
                        velocimetro.Content = rotarAguja.Angle.ToString() + "/Km";

                    }
                    
                }
            }
        }

        private void interruptor_Click(object sender, RoutedEventArgs e)
        {

            barraRevoluciones.Height = 142;
            rotarAguja.Angle = 24;
            interruptor = true;
            encendido.Visibility = Visibility.Visible;
            apagado.Visibility = Visibility.Hidden;
            sport.Visibility = Visibility.Visible;
            modEco.Visibility = Visibility.Visible;
            modNormal.Visibility = Visibility.Visible;
            modEco.IsChecked = false;
            modNormal.IsChecked = false;
            sport.IsChecked = false;

        }

        public void modSport()
        {

            if (sport.IsChecked == true) {

                modEco.Visibility = Visibility.Hidden;
                modNormal.Visibility = Visibility.Hidden;

                if (rotarAguja.Angle < 225 && rotarAguja.Angle > 23)
                {

                    barraRevoluciones.Height -= 10;
                    rotarAguja.Angle = rotarAguja.Angle + 15;
                    velocimetro.Content = rotarAguja.Angle.ToString() + "/Km";

                }

            }
        }

        public void eco() {

            if (modEco.IsChecked == true) {

                sport.Visibility = Visibility.Hidden;
                modNormal.Visibility = Visibility.Hidden;

                if (rotarAguja.Angle < 225 && rotarAguja.Angle > 23) {

                    barraRevoluciones.Height -= 6;
                    rotarAguja.Angle = rotarAguja.Angle + 3;
                    velocimetro.Content = rotarAguja.Angle.ToString() + "/Km";

                }
            }
        }

        public void normal() {


            if (modNormal.IsChecked == true) {

                sport.Visibility = Visibility.Hidden;
                modEco.Visibility = Visibility.Hidden;
                

                if (rotarAguja.Angle < 225 && rotarAguja.Angle > 23)
                {

                    barraRevoluciones.Height -= 6;
                    rotarAguja.Angle = rotarAguja.Angle + 7;
                    velocimetro.Content = rotarAguja.Angle.ToString() + "/Km";
                }
              
                
            }  
        }

        private void encendido_Click(object sender, RoutedEventArgs e)
        {
            encendido.Visibility = Visibility.Hidden;
            apagado.Visibility = Visibility.Visible;
            modEco.Visibility= Visibility.Hidden;
            modNormal.Visibility= Visibility.Hidden;
            sport.Visibility= Visibility.Hidden;
            velocimetro.Content = "";
            rotarAguja.Angle = 0;
        }
    }
}
