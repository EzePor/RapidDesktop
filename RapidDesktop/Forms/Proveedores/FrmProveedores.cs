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

namespace RapidDesktop.Forms.Proveedores
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            RapidDesktopContext context = new RapidDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridProveedores.DataSource = context.Proveedores.Where(c => c.Nombre.Contains(txtBusqueda.Text.Trim())).ToList();
            }
            else
            {
                dataGridProveedores.DataSource = context.Proveedores.ToList();
            }
            //dataGridProveedores.Columns[].Visible = false;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idABorrar = (int)dataGridProveedores.CurrentRow.Cells[0].Value;
            string proveedorABorrar = (string)dataGridProveedores.CurrentRow.Cells[1].Value;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar al proveedor {proveedorABorrar}?", "Eliminar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    var context = new RapidDesktopContext();
                    var proveedor = context.Proveedores.Find(idABorrar);
                    context.Proveedores.Remove(proveedor);
                    context.SaveChanges();
                    CargarGrilla();

                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrió un problema al intentar borrar al proveedor {proveedorABorrar}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoProveedor frmNuevoProveedor = new FrmNuevoProveedor();
            frmNuevoProveedor.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridProveedores.CurrentRow.Cells[0].Value;
            FrmEditarProveedor frmEditarProveedor = new FrmEditarProveedor(idAEditar);
            frmEditarProveedor.ShowDialog();
            CargarGrilla();
        }
    }
}
