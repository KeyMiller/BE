using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class ComprobanteRequest
    {
        public int CodigoRecibo { get; set; }

        public string Tipo { get; set; } = null!;
    }
}
