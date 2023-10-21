using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class UsuarioResponse
    {
        public int Id { get; set; }
        public string? Username { get; set; } = "";
        public string? Password { get; set; } = "";

        public int? IdPersona { get; set; }

        public ulong? Estado { get; set; }
    }
}
