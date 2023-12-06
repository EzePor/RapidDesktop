using RapidDesktop.Data;
using RapidDesktop.Forms.Localidades;
using RapidDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidDesktop.Forms
{
    public partial class FrmEditarCliente : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        int idClienteEditado;
        Cliente? cliente;
        public FrmEditarCliente(int idClienteAEditar)
        {
            InitializeComponent();
            this.idClienteEditado = idClienteAEditar;
            CargarComboLocalidades();
            CargarDatosEnPantalla();

        }

        private void CargarComboLocalidades()
        {
            comboLocalidades.DataSource = context.Localidades.ToList();
            comboLocalidades.DisplayMember = "Nombre";
            comboLocalidades.ValueMember = "Id";

        }

        private void CargarDatosEnPantalla()
        {

            cliente = context.Clientes.Find(idClienteEditado);
            if (cliente != null)
            {
                txtApellidoNombre.Text = cliente.ApellidoNombre;
                txtDireccion.Text = cliente.Dirección;
                txtTelefono.Text = cliente.Teléfono;
                txtEmail.Text = cliente.Email;
                comboLocalidades.SelectedValue = cliente.LocalidadId ?? 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



            cliente.ApellidoNombre = txtApellidoNombre.Text;
            cliente.Dirección = txtDireccion.Text;
            cliente.Teléfono = txtTelefono.Text;
            cliente.Email = txtEmail.Text;
            cliente.LocalidadId = (int)comboLocalidades.SelectedValue;
            context.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


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
