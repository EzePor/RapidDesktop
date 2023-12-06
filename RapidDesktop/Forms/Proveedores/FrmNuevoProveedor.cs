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

namespace RapidDesktop.Forms.Proveedores
{
    public partial class FrmNuevoProveedor : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        public int IdAgregado { get; set; }
        public FrmNuevoProveedor()
        {
            InitializeComponent();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var proveedor = new Proveedor()
            {
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Teléfono = txtTelefono.Text,


            };
            context.Proveedores.Add(proveedor);
            context.SaveChanges();
            IdAgregado = proveedor.Id;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
