using ExamenInforme.Clases;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenInforme
{
    public partial class Form1 : Form
    {
        public string zonaHoria { get; set; }
        public bool ciudadesGrandes { get; set; }
        public string archivo { get; set; }
        public string nombreCiudad { get; set; }

        private int contColumn=0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
            zonaH();
            contadorCol();
            this.reportViewer1.RefreshReport();
            
        }

        private void cargarDatos()
        {
            List<Datos> lista = listaCsv();
            lista = ciudadGrande(lista);

            contColumn=lista.Count;
            ReportDataSource ds = new ReportDataSource("DataSet1", lista);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);

        }
        private List<Datos> listaCsv()
        {

            List<Datos> datos = new List<Datos>();

            List<string> datosCsv = File.ReadAllLines(archivo).ToList();

            //Remove headers
            datosCsv.RemoveAt(0);
            

            foreach (string line in datosCsv)
            {
                string[] parts = line.Split(';');

                Datos dat = new Datos();
                dat.Name = parts[0];
                dat.Latitude = parts[1];
                dat.Longitude =parts[2];
                dat.Population = Convert.ToInt32(parts[3]);
                dat.TimeZone =parts[4];
                datos.Add(dat);
            }
            
            return datos;
        }

        public string bandera() {

            string url = "\\ExamenInforme\\bandera.png";
            return url;
        }

        private void zonaH() {

            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", zonaHoria.ToString()));
        }
        private void contadorCol() {

            reportViewer1.LocalReport.SetParameters(new ReportParameter("contadorColumna",contColumn.ToString()));
        }

        private List<Datos> ciudadGrande(List<Datos> lista) {

            if (ciudadesGrandes)
            {

                lista = lista.FindAll(a => a.Population > 1000000).ToList();
            }
            return lista;
        }
        
}
}
