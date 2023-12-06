using RapidDesktop.Data;
using RapidDesktop.Forms.Fabricantes;
using RapidDesktop.Forms.Proveedores;
using RapidDesktop.Forms.Rubros;
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

namespace RapidDesktop.Forms.Productos
{
    public partial class FrmEditarProducto : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        int idProductoEditado;
        Producto? producto;

        public FrmEditarProducto(int idProductoAEditar)
        {
            InitializeComponent();
            this.idProductoEditado = idProductoAEditar;
            CargarComboRubros();
            CargarCombroProveedores();
            CargarComboFabricantes();
            CargarDatosEnPantalla();
        }

        private void CargarComboFabricantes()
        {
            comboFabricantes.DataSource = context.Fabricantes.ToList();
            comboFabricantes.DisplayMember = "Nombre";
            comboFabricantes.ValueMember = "Id";
            comboProveedores.SelectedValue = 0;
        }

        private void CargarDatosEnPantalla()
        {
            producto = context.Productos.Find(idProductoEditado);
            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = producto.Precio.ToString();
                txtGarantiaFabricante.Text = producto.GarantiaFabricante;
                comboRubros.SelectedValue = producto.RubroId ?? 0;
                comboProveedores.SelectedValue = producto.ProveedorId ?? 0;
                comboFabricantes.SelectedValue = producto.FabricanteId ?? 0;

            }
        }

        private void CargarCombroProveedores()
        {
            comboProveedores.DataSource = context.Proveedores.ToList();
            comboProveedores.DisplayMember = "Nombre";
            comboProveedores.ValueMember = "Id";
            comboProveedores.SelectedValue = 0;
        }

        private void CargarComboRubros()
        {
            comboRubros.DataSource = context.Rubros.ToList();
            comboRubros.DisplayMember = "Nombre";
            comboRubros.ValueMember = "Id";
            comboRubros.SelectedValue = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            producto.Nombre = txtNombre.Text;
            producto.Precio = decimal.Parse(txtPrecio.Text);
            producto.GarantiaFabricante = txtGarantiaFabricante.Text;
            producto.RubroId = (int)comboRubros.SelectedValue;
            producto.ProveedorId = (int)comboProveedores.SelectedValue;
            producto.FabricanteId = (int)comboFabricantes.SelectedValue;
            context.Entry(producto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


            context.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarRubro_Click(object sender, EventArgs e)
        {
            FrmNuevoRubro frmNuevoRubro = new FrmNuevoRubro();
            frmNuevoRubro.ShowDialog();
            CargarComboRubros();
            comboRubros.SelectedValue = frmNuevoRubro.IdAgregado;
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FrmNuevoProveedor frmNuevoProveedor = new FrmNuevoProveedor();
            frmNuevoProveedor.ShowDialog();
            CargarCombroProveedores();
            comboProveedores.SelectedValue = frmNuevoProveedor.IdAgregado;
        }

        private void btnAgregarFabricante_Click(object sender, EventArgs e)
        {
            FrmNuevoFabricante frmNuevoFabricante = new FrmNuevoFabricante();
            frmNuevoFabricante.ShowDialog();
            CargarComboFabricantes();
            comboFabricantes.SelectedValue = frmNuevoFabricante.IdAgregado;
        }
    }
}
