using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class MovimientoCajaRequest
    {
        public int CodigoMovimientoCaja { get; set; }

        public string? Tipo { get; set; }

        public decimal? Monto { get; set; }

        public int CodigoDetallePedido { get; set; }

        public int CodigoCaja { get; set; }
    }
}
