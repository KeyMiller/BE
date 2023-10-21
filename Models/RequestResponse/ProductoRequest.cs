using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class ProductoRequest
    {
        public int CodigoProducto { get; set; }

        public int CodigoUnMedida { get; set; }

        public int CodigoCategoria { get; set; }

        public int CodigoSubCategoria { get; set; }

        public int CodigoPedido { get; set; }

        public string Nombre { get; set; } = null!;

        public string Stock { get; set; } = null!;

        public decimal Precio { get; set; }

        public string Imagen { get; set; } = null!;

        public string Descripcion { get; set; } = null!;
    }
}
