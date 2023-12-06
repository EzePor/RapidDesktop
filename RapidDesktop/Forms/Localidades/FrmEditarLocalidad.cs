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
using Microsoft.EntityFrameworkCore;

namespace RapidDesktop.Forms.Localidades
{
    public partial class FrmEditarLocalidad : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        int idLocalidadEditada;
        Localidad? localidad;

      
        public FrmEditarLocalidad(int idLocalidadAEditar)
        {
            InitializeComponent();
            this.idLocalidadEditada = idLocalidadAEditar;
            CargarComboProvincias();
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {

            localidad = context.Localidades.Find(idLocalidadEditada);
            if (localidad != null)
            {
                txtNombre.Text = localidad.Nombre;
                txtCodigoPostal.Text = localidad.CodigoPostal;

                comboProvincias.SelectedValue = localidad.ProvinciaId ?? 0;
            }
        }

        private void CargarComboProvincias()
        {
            comboProvincias.DataSource = context.Provincias.ToList();
            comboProvincias.DisplayMember = "Nombre";
            comboProvincias.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            localidad.Nombre = txtNombre.Text;
            localidad.CodigoPostal = txtCodigoPostal.Text;

            localidad.ProvinciaId = (int)comboProvincias.SelectedValue;
            context.Entry(localidad).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


            context.SaveChanges();
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
            CargarComboProvincias();
            comboProvincias.SelectedValue = frmNuevaProvincia.IdAgregado;
        }
    }
}
