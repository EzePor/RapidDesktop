using Microsoft.Reporting.WinForms;
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
    public partial class ProveedoresViewForm : Form
    {
        ReportViewer reporte = new ReportViewer();
        RapidDesktopContext context = new RapidDesktopContext();
        public ProveedoresViewForm()
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

        private void ProveedoresViewForm_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "RapidDesktop.Reportes.ProveedoresReport.rdlc";
            var proveedores = context.Proveedores.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSProveedores", proveedores));

            reporte.RefreshReport();
        }
    }
}
