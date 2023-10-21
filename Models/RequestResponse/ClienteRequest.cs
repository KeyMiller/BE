using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class ClienteRequest
    {
        public int CodigoCliente { get; set; }

        public int CodigoPersona { get; set; }

        public string DetallePerfil { get; set; } = null!;

        //public virtual Persona CodigoPersonaNavigation { get; set; } = null!;

        //public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
