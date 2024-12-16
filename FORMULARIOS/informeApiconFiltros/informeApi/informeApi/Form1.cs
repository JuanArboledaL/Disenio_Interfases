using informeApi.Clases;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace informeApi
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
            
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", "Juan Esteban Arboleda"));//Introducir parametro en el report
            this.reportViewer1.RefreshReport();
        }

        public bool checkProp { get; set; }
        public bool id { get; set; }
        private void cargarDatos() {

            Form1 form = new Form1();

            List<Productos> lista = listarProductos();

            if (checkProp) {

                lista = lista.FindAll(a => a.price >= 50).ToList();
            }

            if (id) {

                lista = lista.FindAll(a => a.id == 2).ToList();
            }
            

            ReportDataSource ds = new ReportDataSource("DataSet1", lista);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
        }
        
        private List<Productos> listarProductos() {

            string url = "https://fakestoreapi.com/";
            RestClient cliente = new RestClient(url);
            RestRequest request = new RestRequest("products");
            RestResponse response = cliente.Get(request);

            List<Productos> productos = JsonConvert.DeserializeObject<List<Productos>>(response.Content);

            return productos;
        }

    }
}
