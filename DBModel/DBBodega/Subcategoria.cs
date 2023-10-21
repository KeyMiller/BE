using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Subcategoria
{
    public int CodigoSubCategoria { get; set; }

    public int CodigoCategoria { get; set; }

    public string Tipo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public ulong Estado { get; set; }

    public virtual Categoria CodigoCategoriaNavigation { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
