using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class PersonaResponse
    {
        public int CodigoPersona { get; set; }

        public int CodigoDocumento { get; set; }

        public int CodigoDireccion { get; set; }

        public string Nombres { get; set; } = null!;

        public string ApPaterno { get; set; } = null!;

        public string ApMaterno { get; set; } = null!;

        public string Sexo { get; set; } = null!;

        public DateTime FechaNacimiento { get; set; }

        public string Usuario { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public string Contrasenia { get; set; } = null!;

        public string? Celular { get; set; }

        public ulong Cargo { get; set; }

    }
}
