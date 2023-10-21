using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class EnvioRequest
    {
        public int CodigoEnvio { get; set; }

        public int CodigoRecibo { get; set; }

        public int CodigoDireccion { get; set; }

        public int CodigoColaborativos { get; set; }

       // public virtual Colaborativo CodigoColaborativosNavigation { get; set; } = null!;

       // public virtual Direccione CodigoDireccionNavigation { get; set; } = null!;

        //public virtual Comprobante CodigoReciboNavigation { get; set; } = null!;

       // public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
