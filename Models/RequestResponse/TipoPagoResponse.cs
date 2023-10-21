using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class TipoPagoResponse
    {
        public int CodigoTipopagos { get; set; }

        public string Nombre { get; set; } = null!;

        //public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
    }
}
