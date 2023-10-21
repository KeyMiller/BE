using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class TipoDocumentoRequest
    {
        public string Tipo { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public int CodigoDocumento { get; set; }

        //public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}
