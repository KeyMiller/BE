using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Unidadmedida
{
    public int CodigoUnMedida { get; set; }

    public string Nombre { get; set; } = null!;

    public ulong Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
