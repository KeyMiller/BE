using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Categoria
{
    public int CodigoCategoria { get; set; }

    public string Tipo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public ulong Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<Subcategoria> Subcategoria { get; set; } = new List<Subcategoria>();
}
