using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Detallepedido
{
    public int CodigoDetallePedido { get; set; }

    public decimal PrecioTotal { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int CodigoPedido { get; set; }

    public virtual Pedido CodigoPedidoNavigation { get; set; } = null!;

    public virtual ICollection<Movimientocaja> Movimientocajas { get; set; } = new List<Movimientocaja>();
}
