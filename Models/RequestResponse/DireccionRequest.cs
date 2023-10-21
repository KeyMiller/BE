using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class DireccionRequest
    {
        public int CodigoDireccion { get; set; }

        public string? Ubigeo { get; set; }

        public string? Departamento { get; set; }

        public string? Provincia { get; set; }

        public string? Distrito { get; set; }

        public string? Urbanizacion { get; set; }

        public string Calle { get; set; } = null!;

        public string Referencia { get; set; } = null!;

        // public virtual ICollection<Envio> Envios { get; set; } = new List<Envio>();

        //public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}
