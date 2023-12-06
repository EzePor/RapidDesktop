using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidDesktop.Models
{
    public  class Fabricante
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return  Nombre;
        }
    }
}
