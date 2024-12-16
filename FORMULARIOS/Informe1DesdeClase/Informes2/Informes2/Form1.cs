﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RellenarDataSet();
            this.reportViewer1.RefreshReport();
        }

        private void RellenarDataSet()
        {
            List<Notas> notas = new List<Notas>
            {
                new Notas { Nombre = "Fernando", Nota = 0, Observaciones = "Descargando..." },
                new Notas { Nombre = "Cristian", Nota = 6, Observaciones = "Participativo"},
                new Notas { Nombre = "Álvaro", Nota = 4, Observaciones = "Pone mala nota a Fernado"}
            };


            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", notas);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        }
    }
}
