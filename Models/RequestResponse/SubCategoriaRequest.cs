using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class SubCategoriaRequest
    {
        public int CodigoSubCategoria { get; set; }

        public int CodigoCategoria { get; set; }

        public string Tipo { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public ulong Estado { get; set; }

    }
}
