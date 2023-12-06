using Microsoft.Reporting.WinForms;
using RapidDesktop.Data;
using RapidDesktop.Models;
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
    public partial class ProductosRubrosViewForm : Form
    {
        ReportViewer reporte = new ReportViewer();
        RapidDesktopContext context = new RapidDesktopContext();
        public ProductosRubrosViewForm()
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

        private void ProductosRubrosViewForm_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "RapidDesktop.Reportes.ProductosRubrosReport.rdlc";


            var productos = from producto in context.Productos
                            join rubro in context.Rubros on producto.RubroId equals rubro.Id
                            orderby producto.RubroId
                            select new
                            {
                                Id = producto.Id,
                                Nombre = producto.Nombre,
                                Precio = producto.Precio,
                                GarantiaFabricante = producto.GarantiaFabricante,
                                RubroId = producto.RubroId,
                                Rubro = rubro.Nombre,

                            };
           
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSProductosRubro", productos));

            reporte.RefreshReport();
        }
    }
}
