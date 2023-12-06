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

namespace RapidDesktop.Forms.Provincias
{
    public partial class FrmNuevaProvincia : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        public int IdAgregado { get; set; }
        public FrmNuevaProvincia()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var provincia = new Provincia()
            {
                Nombre = txtNombre.Text,

            };
            context.Provincias.Add(provincia);
            context.SaveChanges();
            IdAgregado = provincia.Id;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
