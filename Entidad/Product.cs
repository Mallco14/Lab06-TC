using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Product
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public DateTime fecha_creacion { get; set; }
        public string estado { get; set; }
    }
}
