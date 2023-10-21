using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Caja
{
    public int CodigoCaja { get; set; }

    public DateTime? Fecha { get; set; }

    public string? UsuarioApertura { get; set; }

    public string? UsuarioCierre { get; set; }

    public ulong Estado { get; set; }

    public decimal? MontoApertura { get; set; }

    public decimal? MontoCierre { get; set; }

    public decimal? MontoAdicional { get; set; }

    public int CodigoColaborativos { get; set; }

    public int Codigopagos { get; set; }

    public virtual Colaborativo CodigoColaborativosNavigation { get; set; } = null!;

    public virtual Pago CodigopagosNavigation { get; set; } = null!;

    public virtual ICollection<Movimientocaja> Movimientocajas { get; set; } = new List<Movimientocaja>();
}
