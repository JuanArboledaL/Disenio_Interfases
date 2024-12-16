using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Crono
{
    public partial class cronometro: UserControl
    {
        private Stopwatch stopwatch;
        
        public cronometro()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            
        }

        public event EventHandler obtenerSegundos;


        Color co = Color.Yellow;
        Color fondo = Color.Gray;
        Color btn = Color.Gray;
        [Category("Ajustes")]
        [Description("Cambia el color del fondo de los botones")]
        public Color colorBotones {
            get { 
            
                return btn;
            }
            set { 
            
                btn = value;
                start.BackColor = btn;
                reset.BackColor = btn;
            } 
        }

        [Category("Ajustes")]
        [Description("Cambia el color del fondo")]
        public Color cambiarFondo {

            get {

                return fondo;
            }
            set {

                fondo = value;
                tableLayoutPanel3.BackColor = fondo;
            } 
        }

        [Category("Ajustes")]
        [Description("Cambia el color de los números")]
        public Color CambiarColor {
            get
            {

                return co;
            }
            set {
                
                co = value;
                cambiarColor(co);

            } 
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (tiempo.Enabled)
            {
                stopwatch.Stop();
                segundos.Stop();
                tiempo.Enabled = false;
            }
            else
            {
                stopwatch.Start();
                segundos.Start();
                tiempo.Enabled = true;
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            stopwatch.Stop();
            tiempo.Enabled = true;
        }

        private void segundos_Tick(object sender, EventArgs e)
        {
            if (punto1.Visible == true && punto2.Visible == true)
            {
                if (obtenerSegundos != null) {

                    obtenerSegundos.Invoke(this, new EventArgs());
                }

                punto1.Visible = false;
                punto2.Visible = false;
            }
            else if (punto1.Visible == false && punto2.Visible == false)
            {

                punto1.Visible = true;
                punto2.Visible = true;
            }
        }
        private void tiempo_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopwatch.ElapsedMilliseconds);

            int minutosUd = ts.Minutes % 10;
            int minutosDe = ts.Minutes / 10 % 10;
            int segundosUd = ts.Seconds % 10;
            int segundosDe = ts.Seconds / 10 % 10;

            

            if (obtenerSegundos != null) { 
            
                obtenerSegundos(this,new EventArgs());
            }

            switch (segundosUd)
            {
                case 1:
                    pintar0001();
                    break;
                case 2:
                    pintar0002();
                    break;
                case 3:
                    pintar0003();
                    break;
                case 4:
                    pintar0004();
                    break;
                case 5:
                    pintar0005();
                    break;
                case 6:
                    pintar0006();
                    break;
                case 7:
                    pintar0007();
                    break;
                case 8:
                    pintar0008();
                    break;
                case 9:
                    pintar0009();
                    break;
                case 0:
                    pintar0000();
                    break;
            }
            switch (segundosDe) { 
            
                case 1:
                    pintar0010();
                    break;
                case 2:
                    pintar0020();
                    break;
                case 3:
                    pintar0030();
                    break;
                case 4:
                    pintar0040();
                    break;
                case 5:
                    pintar0050();
                    break;
                case 6:
                    pintar0060();
                    break;
                case 7:
                    pintar0070();
                    break;
                case 8:
                    pintar0080();
                    break;
                case 9:
                    pintar0090();
                    break;
                case 0:
                    pintar000();
                    break;

            }
            switch (minutosUd) { 
            
                case 1:
                    pintar0100();
                    break;
                case 2:
                    pintar0200();
                    break;
                case 3:
                    pintar0300();
                    break;
                case 4:
                    pintar0400();
                    break;
                case 5:
                    pintar0500();
                    break;
                case 6:
                    pintar0600();
                    break;
                case 7:
                    pintar0700();
                    break;
                case 8:
                    pintar0800();
                    break;
                case 9:
                    pintar0900();
                    break;
                case 0:
                    pintar00();
                    break;
            }
            switch (minutosDe)
            {
                case 1:
                    pintar1000();
                    break;
                case 2:
                    pintar2000();
                    break;
                case 3:
                    pintar3000();
                    break;
                case 4:
                    pintar4000();
                    break;
                case 5:
                    pintar5000();
                    break;
                case 6:
                    pintar6000();
                    break;
                case 7:
                    pintar7000();
                    break;
                case 8:
                    pintar8000();
                    break;
                case 9:
                    pintar9000();
                    break;
                case 0:
                    pintar0();
                    break;
            }

            
        }


        //Unidades de segundos
        private void pintar0000()
        {
            
            dataIV1.Visible = true;
            dataIV2.Visible = true;
            dataIV3.Visible = true;
            dataIV4.Visible = false;
            dataIV5.Visible = true;
            dataIV6.Visible = true;
            dataIV7.Visible = true;
           
        }

        private void pintar0001() {

            dataIV1.Visible = false;
            dataIV2.Visible = false;
            dataIV3.Visible = true;
            dataIV4.Visible = false;
            dataIV5.Visible = false;
            dataIV6.Visible = true;
            dataIV7.Visible = false;
        }

        private void pintar0002() {

            
            dataIV1.Visible = true;
            dataIV2.Visible = false;
            dataIV3.Visible = true;
            dataIV4.Visible = true;
            dataIV5.Visible = true;
            dataIV6.Visible = false;
            dataIV7.Visible = true;
        }

        private void pintar0003() {

            
            dataIV1.Visible = true;
            dataIV2.Visible = false;
            dataIV3.Visible = true;
            dataIV4.Visible = true;
            dataIV5.Visible = false;
            dataIV6.Visible = true;
            dataIV7.Visible = true;

        }

        private void pintar0004() {

           
            dataIV1.Visible = false;
            dataIV2.Visible = true;
            dataIV3.Visible = true;
            dataIV4.Visible = true;
            dataIV5.Visible = false;
            dataIV6.Visible = true;
            dataIV7.Visible = false;

        }

        private void pintar0005() {

            dataIV1.Visible = true;
            dataIV2.Visible = true;
            dataIV3.Visible = false;
            dataIV4.Visible = true;
            dataIV5.Visible = false;
            dataIV6.Visible = true;
            dataIV7.Visible = true;
        }

        private void pintar0006() {

            dataIV1.Visible = true;
            dataIV2.Visible = true;
            dataIV3.Visible = false;
            dataIV4.Visible = true;
            dataIV5.Visible = true;
            dataIV6.Visible = true;
            dataIV7.Visible = true;
        }

        private void pintar0007() {

            dataIV1.Visible = true;
            dataIV2.Visible = false;
            dataIV3.Visible = true;
            dataIV4.Visible = false;
            dataIV5.Visible = false;
            dataIV6.Visible = true;
            dataIV7.Visible = false;
        }

        private void pintar0008() {

            dataIV1.Visible = true;
            dataIV2.Visible = true;
            dataIV3.Visible = true;
            dataIV4.Visible = true;
            dataIV5.Visible = true;
            dataIV6.Visible = true;
            dataIV7.Visible = true;
        }

        private void pintar0009() {

            dataIV1.Visible = true;
            dataIV2.Visible = true;
            dataIV3.Visible = true;
            dataIV4.Visible = true;
            dataIV5.Visible = false;
            dataIV6.Visible = true;
            dataIV7.Visible = false;
        }

        //decenas de segundos
        private void pintar000()
        {

            dataIII1.Visible = true;
            dataIII2.Visible = true;
            dataIII3.Visible = true;
            dataIII4.Visible = false;
            dataIII5.Visible = true;
            dataIII6.Visible = true;
            dataIII7.Visible = true;

        }

        private void pintar0010()
        {

            dataIII1.Visible = false;
            dataIII2.Visible = false;
            dataIII3.Visible = true;
            dataIII4.Visible = false;
            dataIII5.Visible = false;
            dataIII6.Visible = true;
            dataIII7.Visible = false;
        }

        private void pintar0020()
        {


            dataIII1.Visible = true;
            dataIII2.Visible = false;
            dataIII3.Visible = true;
            dataIII4.Visible = true;
            dataIII5.Visible = true;
            dataIII6.Visible = false;
            dataIII7.Visible = true;
        }

        private void pintar0030()
        {


            dataIII1.Visible = true;
            dataIII2.Visible = false;
            dataIII3.Visible = true;
            dataIII4.Visible = true;
            dataIII5.Visible = false;
            dataIII6.Visible = true;
            dataIII7.Visible = true;

        }

        private void pintar0040()
        {


            dataIII1.Visible = false;
            dataIII2.Visible = true;
            dataIII3.Visible = true;
            dataIII4.Visible = true;
            dataIII5.Visible = false;
            dataIII6.Visible = true;
            dataIII7.Visible = false;

        }

        private void pintar0050()
        {

            dataIII1.Visible = true;
            dataIII2.Visible = true;
            dataIII3.Visible = false;
            dataIII4.Visible = true;
            dataIII5.Visible = false;
            dataIII6.Visible = true;
            dataIII7.Visible = true;
        }

        private void pintar0060()
        {

            dataIII1.Visible = true;
            dataIII2.Visible = true;
            dataIII3.Visible = false;
            dataIII4.Visible = true;
            dataIII5.Visible = true;
            dataIII6.Visible = true;
            dataIII7.Visible = true;
        }

        private void pintar0070()
        {

            dataIII1.Visible = true;
            dataIII2.Visible = false;
            dataIII3.Visible = true;
            dataIII4.Visible = false;
            dataIII5.Visible = false;
            dataIII6.Visible = true;
            dataIII7.Visible = false;
        }

        private void pintar0080()
        {

            dataIII1.Visible = true;
            dataIII2.Visible = true;
            dataIII3.Visible = true;
            dataIII4.Visible = true;
            dataIII5.Visible = true;
            dataIII6.Visible = true;
            dataIII7.Visible = true;
        }

        private void pintar0090()
        {

            dataIII1.Visible = true;
            dataIII2.Visible = true;
            dataIII3.Visible = true;
            dataIII4.Visible = true;
            dataIII5.Visible = false;
            dataIII6.Visible = true;
            dataIII7.Visible = false;
        }

        //UNIDADES DE MINUTOS

        private void pintar0100() {

            dataII1.Visible = false;
            dataII2.Visible = false;
            dataII3.Visible = true;
            dataII4.Visible = false;
            dataII5.Visible = false;
            dataII6.Visible = true;
            dataII7.Visible = false;
        }
        private void pintar0200() {

            dataII1.Visible = true;
            dataII2.Visible = false;
            dataII3.Visible = true;
            dataII4.Visible = true;
            dataII5.Visible = true;
            dataII6.Visible = false;
            dataII7.Visible = true;
        }
        private void pintar0300() {

            dataII1.Visible = true;
            dataII2.Visible = false;
            dataII3.Visible = true;
            dataII4.Visible = true;
            dataII5.Visible = false;
            dataII6.Visible = true;
            dataII7.Visible = true;
        }

        private void pintar0400() {

            dataII1.Visible = false;
            dataII2.Visible = true;
            dataII3.Visible = true;
            dataII4.Visible = true;
            dataII5.Visible = false;
            dataII6.Visible = true;
            dataII7.Visible = false;
        }

        private void pintar0500() {

            dataII1.Visible = true;
            dataII2.Visible = true;
            dataII3.Visible = false;
            dataII4.Visible = true;
            dataII5.Visible = false;
            dataII6.Visible = true;
            dataII7.Visible = true;
        }

        private void pintar0600() {

            dataII1.Visible = true;
            dataII2.Visible = true;
            dataII3.Visible = false;
            dataII4.Visible = true;
            dataII5.Visible = true;
            dataII6.Visible = true;
            dataII7.Visible = true;

        }
        private void pintar0700() {

            dataII1.Visible = true;
            dataII2.Visible = false;
            dataII3.Visible = true;
            dataII4.Visible = false;
            dataII5.Visible = false;
            dataII6.Visible = true;
            dataII7.Visible = false;

        }

        private void pintar0800() {

            dataII1.Visible = true;
            dataII2.Visible = true;
            dataII3.Visible = true;
            dataII4.Visible = true;
            dataII5.Visible = true;
            dataII6.Visible = true;
            dataII7.Visible = true;
        }

        private void pintar0900() {

            dataII1.Visible = true;
            dataII2.Visible = true;
            dataII3.Visible = true;
            dataII4.Visible = true;
            dataII5.Visible = false;
            dataII6.Visible = true;
            dataII7.Visible = false;

        }

        private void pintar00() {

            dataII1.Visible = true;
            dataII2.Visible = true;
            dataII3.Visible = true;
            dataII4.Visible = false;
            dataII5.Visible = true;
            dataII6.Visible = true;
            dataII7.Visible = true;

        }

        //DECENAS DE MINUTOS

        private void pintar1000()
        {

            data1.Visible = false;
            data2.Visible = false;
            data3.Visible = true;
            data4.Visible = false;
            data5.Visible = false;
            data6.Visible = true;
            data7.Visible = false;
        }
        private void pintar2000()
        {

            data1.Visible = true;
            data2.Visible = false;
            data3.Visible = true;
            data4.Visible = true;
            data5.Visible = true;
            data6.Visible = false;
            data7.Visible = true;
        }
        private void pintar3000()
        {

            data1.Visible = true;
            data2.Visible = false;
            data3.Visible = true;
            data4.Visible = true;
            data5.Visible = false;
            data6.Visible = true;
            data7.Visible = true;
        }

        private void pintar4000()
        {

            data1.Visible = false;
            data2.Visible = true;
            data3.Visible = true;
            data4.Visible = true;
            data5.Visible = false;
            data6.Visible = true;
            data7.Visible = false;
        }

        private void pintar5000()
        {

            data1.Visible = true;
            data2.Visible = true;
            data3.Visible = false;
            data4.Visible = true;
            data5.Visible = false;
            data6.Visible = true;
            data7.Visible = true;
        }

        private void pintar6000()
        {

            data1.Visible = true;
            data2.Visible = true;
            data3.Visible = false;
            data4.Visible = true;
            data5.Visible = true;
            data6.Visible = true;
            data7.Visible = true;

        }
        private void pintar7000()
        {

            data1.Visible = true;
            data2.Visible = false;
            data3.Visible = true;
            data4.Visible = false;
            data5.Visible = false;
            data6.Visible = true;
            data7.Visible = false;

        }

        private void pintar8000()
        {

            data1.Visible = true;
            data2.Visible = true;
            data3.Visible = true;
            data4.Visible = true;
            data5.Visible = true;
            data6.Visible = true;
            data7.Visible = true;
        }

        private void pintar9000()
        {

            data1.Visible = true;
            data2.Visible = true;
            data3.Visible = true;
            data4.Visible = true;
            data5.Visible = false;
            data6.Visible = true;
            data7.Visible = false;

        }

        private void pintar0()
        {

            data1.Visible = true;
            data2.Visible = true;
            data3.Visible = true;
            data4.Visible = false;
            data5.Visible = true;
            data6.Visible = true;
            data7.Visible = true;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void cambiarColor(Color co) {

            dataIII7.BackgroundColor = co; 
            punto2.BackgroundColor = co;
            punto1.BackgroundColor = co;
            data1.BackgroundColor = co;
            data1.BackgroundColor = co;
            data2.BackgroundColor = co;
            data3.BackgroundColor = co;
            data4.BackgroundColor = co;
            data5.BackgroundColor = co;
            data6.BackgroundColor = co;
            data7.BackgroundColor = co;
            dataII1.BackgroundColor = co;
            dataII2.BackgroundColor = co;
            dataII3.BackgroundColor = co;
            dataII4.BackgroundColor = co;
            dataII5.BackgroundColor = co;
            dataII6.BackgroundColor = co;
            dataII7.BackgroundColor = co;
            dataIII1.BackgroundColor = co;
            dataIII2.BackgroundColor = co;
            dataIII3.BackgroundColor = co;
            dataIII4.BackgroundColor = co;
            dataIII5.BackgroundColor = co;
            dataIII6.BackgroundColor = co;
            dataIV1.BackgroundColor = co;
            dataIV2.BackgroundColor = co;
            dataIV3.BackgroundColor = co;
            dataIV4.BackgroundColor = co;
            dataIV5.BackgroundColor = co;
            dataIV6.BackgroundColor = co;
            dataIV7.BackgroundColor = co;
        }

        
    }
}
