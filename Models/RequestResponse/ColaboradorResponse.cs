using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class ColaboradorResponse
    {
        public int CodigoColaborativos { get; set; }

        public int CodigoPersona { get; set; }

        public int CodigoCargoColaborativos { get; set; }

       public string Usuario { get; set; } = null!;

        public string Foto { get; set; } = null!;

        public string Experiencia { get; set; } = null!;

       // public virtual ICollection<Caja> Cajas { get; set; } = new List<Caja>();

        //public virtual Cargocolaborativo CodigoCargoColaborativosNavigation { get; set; } = null!;

       //public virtual Persona CodigoPersonaNavigation { get; set; } = null!;
    }
}
