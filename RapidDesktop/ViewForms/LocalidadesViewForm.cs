﻿using Microsoft.Reporting.WinForms;
using RapidDesktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidDesktop.ViewForms
{
    public partial class LocalidadesViewForm : Form
    {
        ReportViewer reporte = new ReportViewer();
        RapidDesktopContext context = new RapidDesktopContext();
        public LocalidadesViewForm()
        {
            InitializeComponent();

            //reporte ocupe todo el formulario
            reporte.Dock = DockStyle.Fill;

            // establece la vista de impresion
            reporte.SetDisplayMode(DisplayMode.PrintLayout);

            // Zoom 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;

            Controls.Add(reporte);
        }

        private void LocalidadesViewForm_Load(object sender, EventArgs e)
        {

            reporte.LocalReport.ReportEmbeddedResource = "RapidDesktop.Reportes.LocalidadesReport.rdlc";
            var localidades = context.Localidades.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSLocalidades", localidades));

            reporte.RefreshReport();
        }
    }
}
