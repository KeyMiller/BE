using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class PedidoRequest
    {
        public int CodigoPedido { get; set; }

        public int CodigoCliente { get; set; }

        public int CodigoEnvio { get; set; }

        public int Codigopagos { get; set; }

        public DateTime RegistroPe { get; set; }

        public DateTime EntregaPe { get; set; }

    }
}
