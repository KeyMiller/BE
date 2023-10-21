using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class CargoColaborativoRequest
    {
        public int CodigoCargo { get; set; }

        public string Nombre { get; set; } = null!;

        public string Funcion { get; set; } = null!;

       // public virtual ICollection<Colaborativo> Colaborativos { get; set; } = new List<Colaborativo>();
    }
}
