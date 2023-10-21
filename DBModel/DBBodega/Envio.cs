using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Envio
{
    public int CodigoEnvio { get; set; }

    public int CodigoRecibo { get; set; }

    public int CodigoDireccion { get; set; }

    public int CodigoColaborativos { get; set; }

    public virtual Colaborativo CodigoColaborativosNavigation { get; set; } = null!;

    public virtual Direccione CodigoDireccionNavigation { get; set; } = null!;

    public virtual Comprobante CodigoReciboNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
