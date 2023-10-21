using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Pago
{
    public int Codigopagos { get; set; }

    public decimal Monto { get; set; }

    public int CodigoTipopagos { get; set; }

    public virtual ICollection<Caja> Cajas { get; set; } = new List<Caja>();

    public virtual Tipopago CodigoTipopagosNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
