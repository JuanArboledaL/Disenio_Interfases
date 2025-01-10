using System;
using System.Collections.Generic;
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

namespace RevolucionesCocheWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void acelerador_Click(object sender, RoutedEventArgs e)
        {
            RotateTransform transform = new RotateTransform();
            transform.Angle = 28;
        }

        private void freno_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
