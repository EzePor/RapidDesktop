using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidDesktop.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? ApellidoNombre { get; set; }
        public string? Dirección { get; set; }
        public string?  Teléfono { get; set; }
        public string? Email { get; set; }

        public int? LocalidadId { get; set; }

        public Localidad Localidad { get; set; }

        public override string ToString()
        {
            return ApellidoNombre;
        }

    }
}
