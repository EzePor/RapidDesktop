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

namespace RapidDesktop.Forms.Proveedores
{
    public partial class FrmEditarProveedor : Form
    {

        RapidDesktopContext context = new RapidDesktopContext();
        int idProveedorEditado;
        Proveedor? proveedor;
        public FrmEditarProveedor(int idProveedorAEditar)
        {
            InitializeComponent();
            this.idProveedorEditado = idProveedorAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            proveedor = context.Proveedores.Find(idProveedorEditado);
            if (proveedor != null)
            {
                txtNombre.Text = proveedor.Nombre;
                txtEmail.Text = proveedor.Email;
                txtTelefono.Text = proveedor.Teléfono;


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            proveedor.Nombre = txtNombre.Text;
            proveedor.Email = txtEmail.Text;
            proveedor.Teléfono = txtTelefono.Text;

            context.Entry(proveedor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


            context.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
