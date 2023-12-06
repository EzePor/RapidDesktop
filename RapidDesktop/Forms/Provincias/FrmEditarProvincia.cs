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
    public partial class FrmEditarProvincia : Form
    {
        RapidDesktopContext context = new RapidDesktopContext();
        int idProvinciaEditada;
        Provincia? provincia;

      
        public FrmEditarProvincia(int idProvinciaAEditar)
        {
            InitializeComponent();
            this.idProvinciaEditada = idProvinciaAEditar;
          
            CargarDatosEnPantalla();
           
        }

        private void CargarDatosEnPantalla()
        {
            provincia = context.Provincias.Find( idProvinciaEditada);
            if (provincia != null)
            {
                txtNombre.Text = provincia.Nombre;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            provincia.Nombre = txtNombre.Text;



            context.Entry(provincia).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


            context.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
