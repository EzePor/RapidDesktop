using Microsoft.EntityFrameworkCore;
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

namespace RapidDesktop.Forms.Productos
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            RapidDesktopContext context = new RapidDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridProductos.DataSource = context.Productos.Where(p => p.Nombre.Contains(txtBusqueda.Text.Trim())).Include(c => c.Rubro).Include(p => p.Proveedor).Include(f=>f.Fabricante).ToList();
            }
            else
            {
                dataGridProductos.DataSource = context.Productos.Include(c => c.Rubro).Include(p => p.Proveedor).Include(f=>f.Fabricante).ToList();
            }
            dataGridProductos.Columns[4].Visible = false;
            dataGridProductos.Columns[6].Visible = false;
            dataGridProductos.Columns[8].Visible = false;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            frmNuevoProducto.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridProductos.CurrentRow.Cells[0].Value;
            FrmEditarProducto frmEditarProducto = new FrmEditarProducto(idAEditar);
            frmEditarProducto.ShowDialog();
            CargarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idABorrar = (int)dataGridProductos.CurrentRow.Cells[0].Value;
            string productoABorrar = (string)dataGridProductos.CurrentRow.Cells[1].Value + " " + dataGridProductos.CurrentRow.Cells[2].Value;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar el producto {productoABorrar}?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    var context = new RapidDesktopContext();
                    var producto = context.Productos.Find(idABorrar);
                    context.Productos.Remove(producto);
                    context.SaveChanges();
                    CargarGrilla();

                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrió un problema al intentar borrar el producto {productoABorrar}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
