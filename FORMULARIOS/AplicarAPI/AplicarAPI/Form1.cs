using AplicarAPI.Clases;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * https://fakestoreapi.com/products
 * mostrar con encabezado y pie de página, parametros y número de página
 * cuerpo: tabla con la informacion de la api
 * llamada API: nuget -> Restshop
 * Crear un objeto con los campos API
 * Deserealizar Json el objeto -> Nuget: NewtonSoftJson
 */

namespace AplicarAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
            this.reportViewer1.RefreshReport();
        }

        private void cargarDatos() {

            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", "Juan Esteban Arboleda López"));
            List<Productos> productos = Api.Acceso();
            
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1",productos);
            
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        }


    }

    
}
