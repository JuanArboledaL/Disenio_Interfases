using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoInformeAPI
{
    public partial class Form1 : Form
    {
        private int contRow = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            importApiData(reportViewer1);
            //reportViewer1();

            this.reportViewer1.RefreshReport();
        }

        private void importApiData(ReportViewer report) { 
        
            RestClient client = new RestClient("http://fakestoreapi.com/");
            RestRequest request = new RestRequest("products");

            RestResponse response = client.Execute(request);
            List<clases.Datos> listProducts = JsonConvert.DeserializeObject<List<clases.Datos>>(response.Content);
            List<clases.Rating> listaRating = new List<clases.Rating>();

            foreach (clases.Datos product in listProducts) {

                listaRating.Add(product.rating);
                contRow++;
            }

            report.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet1", listProducts);
            report.LocalReport.DataSources.Add(reportDataSource1);

            ReportDataSource reportDataSource2 = new ReportDataSource("DataSet2", listaRating);
            report.LocalReport.DataSources.Add(reportDataSource2);

        }
    }
}
