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

namespace RapidDesktop.Forms.Localidades
{
    public partial class FrmLocalidades : Form
    {
        public FrmLocalidades()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            RapidDesktopContext context = new RapidDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridLocalidades.DataSource = context.Localidades.Where(l => l.Nombre.Contains(txtBusqueda.Text.Trim())).Include(c => c.Provincia).ToList();
            }
            else
            {
                dataGridLocalidades.DataSource = context.Localidades.Include(l => l.Provincia).ToList();
            }
            dataGridLocalidades.Columns[3].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaLocalidad frmNuevaLocalidad = new FrmNuevaLocalidad();
            frmNuevaLocalidad.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridLocalidades.CurrentRow.Cells[0].Value;
            FrmEditarLocalidad frmEditarlocalidad = new FrmEditarLocalidad(idAEditar);
            frmEditarlocalidad.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idABorrar = (int)dataGridLocalidades.CurrentRow.Cells[0].Value;
            string localidadABorrar = (string)dataGridLocalidades.CurrentRow.Cells[1].Value + " " + dataGridLocalidades.CurrentRow.Cells[2].Value;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar la Localidad {localidadABorrar}?", "Eliminar localidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    var context = new RapidDesktopContext();
                    var localidad = context.Localidades.Find(idABorrar);
                    context.Localidades.Remove(localidad);
                    context.SaveChanges();
                    CargarGrilla();

                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrió un problema al intentar borrar la localidad {localidadABorrar}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
