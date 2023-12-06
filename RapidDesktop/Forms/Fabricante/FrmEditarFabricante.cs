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

namespace RapidDesktop.Forms.Fabricantes
{
    public partial class FrmEditarFabricante : Form
    {

        RapidDesktopContext context = new RapidDesktopContext();
        int idFabricanteEditado;
        Fabricante? fabricante;
        public FrmEditarFabricante(int idFabricanteAEditar)
        {
            InitializeComponent();
            this.idFabricanteEditado = idFabricanteAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            fabricante = context.Fabricantes.Find(idFabricanteEditado);
            if (fabricante != null)
            {
                txtNombre.Text = fabricante.Nombre;
                txtNacionalidad.Text = fabricante.Nacionalidad;
                txtEmail.Text = fabricante.Email;


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            fabricante.Nombre = txtNombre.Text;
            fabricante.Nacionalidad = txtNacionalidad.Text;
            fabricante.Email = txtEmail.Text;

            context.Entry(fabricante).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


            context.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
