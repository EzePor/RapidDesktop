using RapidDesktop.Data;
using RapidDesktop.Forms.Localidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidDesktop.Forms.Provincias
{
    public partial class FrmProvincia : Form
    {
        public FrmProvincia()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {

            RapidDesktopContext context = new RapidDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridProvincias.DataSource = context.Provincias.Where(l => l.Nombre.Contains(txtBusqueda.Text.Trim())).ToList();
            }
            else
            {
                dataGridProvincias.DataSource = context.Provincias.ToList();
            }
        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaProvincia frmNuevaProvincia = new FrmNuevaProvincia();
            frmNuevaProvincia.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridProvincias.CurrentRow.Cells[0].Value;
            FrmEditarProvincia frmEditarProvincia = new FrmEditarProvincia     (idAEditar);
            frmEditarProvincia.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idABorrar = (int)dataGridProvincias.CurrentRow.Cells[0].Value;
            string provinciaABorrar = (string)dataGridProvincias.CurrentRow.Cells[1].Value;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar la Provincia {provinciaABorrar}?", "Eliminar provincia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    var context = new RapidDesktopContext();
                    var provincia = context.Provincias.Find(idABorrar);
                    context.Provincias.Remove(provincia);
                    context.SaveChanges();
                    CargarGrilla();

                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrió un problema al intentar borrar la provincia {provinciaABorrar}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
