using Microsoft.Reporting.WinForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rellenarDatos();
            this.reportViewer1.RefreshReport();

        }

        public void rellenarDatos() {

            tablaDepartamento();

        }

        public void tablaDepartamento() {

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=iesbelen; Database=empleados"))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM departamento", conn);

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adaptador.Fill(dt);

                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                conn.Close();
            }

        }

        public void tablaEmpleados() {

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=iesbelen; Database=empleados"))
            {
                conn.Open();

                NpgsqlCommand cmd2 = new NpgsqlCommand("SELECT * FROM empleado", conn);

                NpgsqlDataAdapter adaptador2 = new NpgsqlDataAdapter(cmd2);

                DataTable dt2 = new DataTable();

                adaptador2.Fill(dt2);

                ReportDataSource reportDataSource2 = new ReportDataSource("DataSet2", dt2);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                conn.Close();
            }
              
        }
    }
}
