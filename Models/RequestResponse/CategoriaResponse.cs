using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public  class CategoriaResponse
    {
        public int CodigoCategoria { get; set; }

        public string Tipo { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public ulong Estado { get; set; }

        //  public virtual ICollection<ProductoResponse> Productos { get; set; } = new List<Producto>();

        // public virtual ICollection<SubcategoriaResponse> Subcategoria { get; set; } = new List<Subcategoria>();
    }
}
