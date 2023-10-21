using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Tipodocumento
{
    public string Tipo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int CodigoDocumento { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
