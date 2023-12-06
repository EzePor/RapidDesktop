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

    public partial class FrmEditarRubro : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        int idRubroEditado;
        Rubro? rubro;
        public FrmEditarRubro(int idRubroAEditar)
        {
            InitializeComponent();
            this.idRubroEditado = idRubroAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            rubro = context.Rubros.Find(idRubroEditado);
            if (rubro != null)
            {
                txtNombre.Text = rubro.Nombre;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rubro.Nombre = txtNombre.Text;

            context.Entry(rubro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


            context.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
