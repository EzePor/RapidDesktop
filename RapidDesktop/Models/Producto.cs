using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidDesktop.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public string? GarantiaFabricante { get; set; }  
        public int? RubroId { get; set; }    
        public Rubro Rubro { get; set; }
        public int? ProveedorId { get; set; }    
        public Proveedor Proveedor { get; set; }
        public int? FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }  



        public override string ToString()
        {
            return $"{Nombre} {Precio}";
        }
    }
}
