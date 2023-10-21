using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Pedido
{
    public int CodigoPedido { get; set; }

    public int CodigoCliente { get; set; }

    public int CodigoEnvio { get; set; }

    public int Codigopagos { get; set; }

    public DateTime RegistroPe { get; set; }

    public DateTime EntregaPe { get; set; }

    public virtual Cliente CodigoClienteNavigation { get; set; } = null!;

    public virtual Envio CodigoEnvioNavigation { get; set; } = null!;

    public virtual Pago CodigopagosNavigation { get; set; } = null!;

    public virtual ICollection<Detallepedido> Detallepedidos { get; set; } = new List<Detallepedido>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
