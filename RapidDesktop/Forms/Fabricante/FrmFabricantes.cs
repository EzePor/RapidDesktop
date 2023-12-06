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

namespace RapidDesktop.Forms.Fabricantes
{
    public partial class FrmFabricantes : Form
    {
        public FrmFabricantes()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            RapidDesktopContext context = new RapidDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridFabricantes.DataSource = context.Fabricantes.Where(p => p.Nombre.Contains(txtBusqueda.Text.Trim())).ToList();
            }
            else
            {
                dataGridFabricantes.DataSource = context.Fabricantes.ToList();
            }
            dataGridFabricantes.Columns[3].Visible = false;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoFabricante frmNuevoFabricante = new FrmNuevoFabricante();
            frmNuevoFabricante.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridFabricantes.CurrentRow.Cells[0].Value;
            FrmEditarFabricante frmEditarFabricante = new FrmEditarFabricante(idAEditar);
            frmEditarFabricante.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idABorrar = (int)dataGridFabricantes.CurrentRow.Cells[0].Value;
            string fabricanteABorrar = (string)dataGridFabricantes.CurrentRow.Cells[1].Value;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar al fabricante {fabricanteABorrar}?", "Eliminar fabricante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    var context = new RapidDesktopContext();
                    var fabricante = context.Fabricantes.Find(idABorrar);
                    context.Fabricantes.Remove(fabricante);
                    context.SaveChanges();
                    CargarGrilla();

                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrió un problema al intentar borrar al fabricante {fabricanteABorrar}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
