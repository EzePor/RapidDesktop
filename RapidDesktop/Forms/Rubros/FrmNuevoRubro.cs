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

namespace RapidDesktop.Forms.Rubros
{
    public partial class FrmNuevoRubro : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        public int IdAgregado { get; set; }
        public FrmNuevoRubro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var rubro = new Rubro()
            {
                Nombre = txtNombre.Text,



            };
            context.Rubros.Add(rubro);
            context.SaveChanges();
            IdAgregado = rubro.Id;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
