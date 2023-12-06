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
    public partial class FrmNuevoFabricante : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        public int IdAgregado { get; set; }
        public FrmNuevoFabricante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var fabricante = new Fabricante()
            {
                Nombre = txtNombre.Text,
                Nacionalidad = txtNacionalidad.Text,
                Email = txtEmail.Text,


            };
            context.Fabricantes.Add(fabricante);
            context.SaveChanges();
            IdAgregado = fabricante.Id;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
