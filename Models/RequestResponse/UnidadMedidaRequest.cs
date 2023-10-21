using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class UnidadMedidaRequest
    {
        public int CodigoUnMedida { get; set; }

        public string Nombre { get; set; } = null!;

        public ulong Estado { get; set; }

      
    }
}
