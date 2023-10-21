using System;
using System.Collections.Generic;

namespace DBModel.DBBodega;

public partial class Producto
{
    public int CodigoProducto { get; set; }

    public int CodigoUnMedida { get; set; }

    public int CodigoCategoria { get; set; }

    public int CodigoSubCategoria { get; set; }

    public int CodigoPedido { get; set; }

    public string Nombre { get; set; } = null!;

    public string Stock { get; set; } = null!;

    public decimal Precio { get; set; }

    public string Imagen { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual Categoria CodigoCategoriaNavigation { get; set; } = null!;

    public virtual Pedido CodigoPedidoNavigation { get; set; } = null!;

    public virtual Subcategoria CodigoSubCategoriaNavigation { get; set; } = null!;

    public virtual Unidadmedida CodigoUnMedidaNavigation { get; set; } = null!;
}
