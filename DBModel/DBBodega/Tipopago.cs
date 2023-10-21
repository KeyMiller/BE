using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Tipopago
{
    public int CodigoTipopagos { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
