using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModel
{
    public class TokenClaims
    {
        public int Id { get; set; } = 0;
        public string Nombre { get; set; } = "";
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Id_Persona { get; set; } = "";
        public string Estado { get; set; } = "";
    }
}
