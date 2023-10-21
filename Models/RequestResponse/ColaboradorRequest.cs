using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class ColaboradorRequest
    {
        public int CodigoColaborativos { get; set; }

        public int CodigoPersona { get; set; }

        public int CodigoCargoColaborativos { get; set; }

        public string Usuario { get; set; } = null!;

        public string Foto { get; set; } = null!;

        public string Experiencia { get; set; } = null!;
        public string? Username { get; set; }
        public string? Password { get; set; }

    }
}
