using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Comprobante
{
    public int CodigoRecibo { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Envio> Envios { get; set; } = new List<Envio>();
}
