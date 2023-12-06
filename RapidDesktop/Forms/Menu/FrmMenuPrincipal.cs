using RapidDesktop.Forms.Fabricantes;
using RapidDesktop.Forms.Localidades;
using RapidDesktop.Forms.MenuSecundario;
using RapidDesktop.Forms.Productos;
using RapidDesktop.Forms.Proveedores;
using RapidDesktop.Forms.Provincias;
using RapidDesktop.Forms.Rubros;
using RapidDesktop.ViewForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidDesktop.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void gestiónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();

        }

        private void gestiónDeLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalidades frmLocalidades = new FrmLocalidades();
            frmLocalidades.ShowDialog();
        }

        private void gestiónDeProvinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProvincia frmProvincia = new FrmProvincia();
            frmProvincia.ShowDialog();

        }

        private void gestiónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.ShowDialog();
        }

        private void gestiónDeRubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRubros frmRubros = new FrmRubros();
            frmRubros.ShowDialog();
        }

        private void gestiónDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.ShowDialog();
        }

        private void gestiónDeFabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFabricantes frmFabricantes = new FrmFabricantes();
            frmFabricantes.ShowDialog();
        }

        private void listadoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesViewForm clientesViewForm = new ClientesViewForm();
            clientesViewForm.ShowDialog();
        }

        private void listadoDeLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalidadesViewForm localidadesViewForm = new LocalidadesViewForm(); localidadesViewForm.ShowDialog();
        }

        private void listadoDeProvinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinciasViewForm provinciasViewForm = new ProvinciasViewForm();
            provinciasViewForm.ShowDialog();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosViewForm productosViewForm = new ProductosViewForm();
            productosViewForm.ShowDialog();
        }

        private void listadoDeRubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RubrosViewForm rubrosViewForm = new RubrosViewForm();
            rubrosViewForm.ShowDialog();
        }

        private void lIstadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedoresViewForm proveedoresViewForm = new ProveedoresViewForm();
            proveedoresViewForm.ShowDialog();
        }

        private void listadoDeFabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FabricantesViewForm fabricantesViewForm = new FabricantesViewForm();
            fabricantesViewForm.ShowDialog();
        }

        private void listadoDeProductosPorRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosRubrosViewForm productosRubrosViewForm = new ProductosRubrosViewForm();
            productosRubrosViewForm.ShowDialog();
        }

        private void copiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcerdaDe frmAcerdaDe = new FrmAcerdaDe();
            frmAcerdaDe.ShowDialog();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
