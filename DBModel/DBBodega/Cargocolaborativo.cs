using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Cargocolaborativo
{
    public int CodigoCargo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Funcion { get; set; } = null!;

    public virtual ICollection<Colaborativo> Colaborativos { get; set; } = new List<Colaborativo>();
}
