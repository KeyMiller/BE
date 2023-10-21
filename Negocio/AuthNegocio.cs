using AutoMapper;
using INegocio;
using Models.RequestResponse;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilSecurity;

namespace Negocio
{
    public class AuthNegocio : IAuthNegocio
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioNegocio _userNegocio;
        private readonly UtilCripto _cripto;
        public AuthNegocio(IMapper mapper)
        {
           _userNegocio = new UsuarioNegocio(mapper);
            _mapper = mapper;
            _cripto= new UtilCripto();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public LoginResponse login(LoginRequest request)
        {
            LoginResponse res = new LoginResponse();
            //validamos que usuario exista
            UsuarioResponse user = _userNegocio.GetByUserName(request.Username);
            if (user.Username != null && !(user.Username.ToLower() == request.Username.ToLower()))
            {
                res.Message = "Usuario y/o password invalido";
                res.Usuario = null;
                return res;
            }

            string newPassword = _cripto.encriptar_AES(request.Password);
            if (!(newPassword == user.Password))
            {
                res.Message = "Usuario y/o password valido";
                res.Usuario = null;
                return res;
            }
            res.Usuario = user;
            return res;
        }
    }

  
}
