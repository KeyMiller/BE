using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class PedidoResponse
    {
        public int CodigoPedido { get; set; }

        public int CodigoCliente { get; set; }

        public int CodigoEnvio { get; set; }

        public int Codigopagos { get; set; }

        public DateTime RegistroPe { get; set; }

        public DateTime EntregaPe { get; set; }

        //public virtual Cliente CodigoClienteNavigation { get; set; } = null!;

        //public virtual Envio CodigoEnvioNavigation { get; set; } = null!;

        //public virtual Pago CodigopagosNavigation { get; set; } = null!;

        //public virtual ICollection<Detallepedido> Detallepedidos { get; set; } = new List<Detallepedido>();

        //public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
