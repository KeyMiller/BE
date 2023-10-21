using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class CategoriaRequest
    {
        public int CodigoCategoria { get; set; }

        public string Tipo { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public ulong Estado { get; set; }

      //  public virtual ICollection<ProductoRequest> Productos { get; set; } = new List<Producto>();

       // public virtual ICollection<SubcategoriaRequest> Subcategoria { get; set; } = new List<Subcategoria>();
    }
}
