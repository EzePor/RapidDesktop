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

namespace RapidDesktop.Forms.Rubros
{
    public partial class FrmRubros : Form
    {
        public FrmRubros()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {

            RapidDesktopContext context = new RapidDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridRubros.DataSource = context.Rubros.Where(l => l.Nombre.Contains(txtBusqueda.Text.Trim())).ToList();
            }
            else
            {
                dataGridRubros.DataSource = context.Rubros.ToList();
            }
            // dataGridRubros.Columns[3].Visible = false;
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
            FrmNuevoRubro frmNuevoRubro = new FrmNuevoRubro();
            frmNuevoRubro.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridRubros.CurrentRow.Cells[0].Value;
            FrmEditarRubro frmEditarRubro = new FrmEditarRubro(idAEditar);
            frmEditarRubro.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int idABorrar = (int)dataGridRubros.CurrentRow.Cells[0].Value;
            string rubroABorrar = (string)dataGridRubros.CurrentRow.Cells[1].Value ;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar el rubro {rubroABorrar}?", "Eliminar rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    var context = new RapidDesktopContext();
                    var rubro = context.Rubros.Find(idABorrar);
                    context.Rubros.Remove(rubro);
                    context.SaveChanges();
                    CargarGrilla();

                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrió un problema al intentar borrar el producto {rubroABorrar}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
