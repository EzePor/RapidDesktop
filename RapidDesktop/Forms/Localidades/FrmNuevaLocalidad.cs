using RapidDesktop.Data;
using RapidDesktop.Forms.Provincias;
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

namespace RapidDesktop.Forms.Localidades
{
    public partial class FrmNuevaLocalidad : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        public int IdAgregado { get; set; }
        public FrmNuevaLocalidad()
        {
            InitializeComponent();
            CargarComboProvincia();
        }

        private void CargarComboProvincia()
        {
            comboProvincias.DataSource = context.Provincias.ToList();
            comboProvincias.DisplayMember = "Nombre";
            comboProvincias.ValueMember = "Id";
            comboProvincias.SelectedValue = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var localidad = new Localidad()
            {
                Nombre = txtNombre.Text,
                CodigoPostal = txtCodigoPostal.Text,

                ProvinciaId = (int)comboProvincias.SelectedValue
            };
            context.Localidades.Add(localidad);
            context.SaveChanges();
            IdAgregado = localidad.Id;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProvincia_Click(object sender, EventArgs e)
        {
            FrmNuevaProvincia frmNuevaProvincia = new FrmNuevaProvincia();
            frmNuevaProvincia.ShowDialog();
            CargarComboProvincia();
            comboProvincias.SelectedValue = frmNuevaProvincia.IdAgregado;
        }
    }
}
