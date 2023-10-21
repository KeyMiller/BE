
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class LoginResponse
    {
        public bool Success { get; set; } = false;
        public UsuarioResponse? Usuario { get; set; } =null;
        public PersonaResponse? Persona { get; set; } = null; 
        public string Token { get; set; } = "";
        public string RefreshToken { get; set; } = "";
        public string Message { get; set; } = "Usuario y/o password incorrecto";

    }
}
