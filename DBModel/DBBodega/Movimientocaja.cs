using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Movimientocaja
{
    public int CodigoMovimientoCaja { get; set; }

    public string? Tipo { get; set; }

    public decimal? Monto { get; set; }

    public int CodigoDetallePedido { get; set; }

    public int CodigoCaja { get; set; }

    public virtual Caja CodigoCajaNavigation { get; set; } = null!;

    public virtual Detallepedido CodigoDetallePedidoNavigation { get; set; } = null!;
}
