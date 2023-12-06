using RapidDesktop.Data;
using RapidDesktop.Forms.Localidades;
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

namespace RapidDesktop.Forms
{
    public partial class FrmNuevoCliente : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
      
        public FrmNuevoCliente()
        {
            InitializeComponent();
            CargarComboLocalidades();
        }

        private void CargarComboLocalidades()
        {
            comboLocalidades.DataSource = context.Localidades.ToList();
            comboLocalidades.DisplayMember = "Nombre";
            comboLocalidades.ValueMember = "Id";
            comboLocalidades.SelectedValue = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var cliente = new Cliente()
            {
                ApellidoNombre = txtApellidoNombre.Text,
                Dirección = txtDireccion.Text,
                Teléfono = txtTelefono.Text,
                Email = txtEmail.Text,
                LocalidadId = (int)comboLocalidades.SelectedValue
            };
            context.Clientes.Add(cliente);
            context.SaveChanges();
            this.Close();
        }

        private void btnAgregarLocalidad_Click(object sender, EventArgs e)
        {
            FrmNuevaLocalidad frmNuevaLocalidad = new FrmNuevaLocalidad();
            frmNuevaLocalidad.ShowDialog();
            CargarComboLocalidades();
            comboLocalidades.SelectedValue = frmNuevaLocalidad.IdAgregado;
        }
    }
}
