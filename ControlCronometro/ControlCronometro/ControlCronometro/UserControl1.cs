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

namespace ControlCronometro
{
    public partial class UserControl1: UserControl
    {
        private Stopwatch stopwatch;
        public UserControl1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                stopwatch.Stop();
                timer.Enabled = false;
            }
            else
            {
                stopwatch.Start();
                timer.Enabled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            stopwatch.Stop();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int) stopwatch.ElapsedMilliseconds);
   
            int minutosUd = ts.Minutes % 10;
            int minutosDe = ts.Minutes / 10 % 10;
            int segundosUd = ts.Seconds % 10;
            int segundosDe = ts.Seconds / 10 % 10;

            switch (segundosUd)
            {
                case 1:
                    dataGridView22.Visible = false;
                    dataGridView23.Visible = false;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = false;
                    dataGridView28.Visible = false;
                    break;
                case 2:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = true;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = false;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = false;
                    break ;
                case 3:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = false;
                    break;
                case 4:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = false;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = false;
                    dataGridView28.Visible = true;
                    break;
                case 5:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = false;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
                case 6:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = true;
                    dataGridView25.Visible = false;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
                case 7:
                    dataGridView22.Visible = false;
                    dataGridView23.Visible = false;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = false;
                    break;
                case 8:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = true;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
                case 9:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
                case 0:
                    dataGridView22.Visible = false;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = true;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
            }

            switch (segundosDe)
            {
                case 1:
                    dataGridView15.Visible = false;
                    dataGridView16.Visible = false;
                    dataGridView17.Visible = false;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = false;
                    dataGridView21.Visible = false;
                    break;
                case 2:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = true;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = false;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = false;
                    break;
                case 3:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = false;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = false;
                    break;
                case 4:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = false;
                    dataGridView17.Visible = false;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = false;
                    dataGridView21.Visible = true;
                    break;
                case 5:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = false;
                    dataGridView18.Visible = false;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = true;
                    break;
                case 6:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = true;
                    dataGridView18.Visible = false;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = true;
                    break;
                case 0:
                    dataGridView15.Visible = false;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = true;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = true;
                    break;
            }

            switch (minutosUd)
            {
                case 1:
                    dataGridView4.Visible = false;
                    dataGridView5.Visible = false;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = false;
                    dataGridView14.Visible = false;
                    break;
                case 2:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = false;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = false;
                    break;
                case 3:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = false;
                    break;
                case 4:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = false;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = false;
                    dataGridView14.Visible = true;
                    break;
                case 5:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = false;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 6:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = false;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 7:
                    dataGridView4.Visible = false;
                    dataGridView5.Visible = false;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = false;
                    break;
                case 8:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 9:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 0:
                    dataGridView4.Visible = false;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
            }

            switch (minutosDe)
            {
                case 1:
                    dataGridView4.Visible = false;
                    dataGridView5.Visible = false;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = false;
                    dataGridView14.Visible = false;
                    break;
                case 2:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = false;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = false;
                    break;
                case 3:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = false;
                    break;
                case 4:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = false;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = false;
                    dataGridView14.Visible = true;
                    break;
                case 5:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = false;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 6:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = false;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 0:
                    dataGridView4.Visible = false;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
            }
        }

    }
}
