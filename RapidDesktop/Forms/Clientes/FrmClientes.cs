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

namespace RapidDesktop.Forms
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            RapidDesktopContext context = new RapidDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridClientes.DataSource = context.Clientes.Where(c => c.ApellidoNombre.Contains(txtBusqueda.Text.Trim())).Include(c=>c.Localidad).ToList();
            }
            else
            {
                dataGridClientes.DataSource = context.Clientes.Include(c => c.Localidad).ToList();
            }
            dataGridClientes.Columns[5].Visible = false;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idABorrar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            string clienteABorrar = (string)dataGridClientes.CurrentRow.Cells[1].Value + " " + dataGridClientes.CurrentRow.Cells[2].Value;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar al cliente {clienteABorrar}?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    var context = new RapidDesktopContext();
                    var cliente = context.Clientes.Find(idABorrar);
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                    CargarGrilla();

                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrió un problema al intentar borrar al cliente {clienteABorrar}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente();
            frmNuevoCliente.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            FrmEditarCliente frmEditarCliente = new FrmEditarCliente(idAEditar);
            frmEditarCliente.ShowDialog();
            CargarGrilla();

        }

       
    }
}
