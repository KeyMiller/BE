using Models.RequestResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilInterface;

namespace INegocio
{
    public interface IUsuarioNegocio : ICRUDNegocio<UsuarioRequest, UsuarioResponse>
    {
        UsuarioResponse GetByUserName(string userName);
    }
}
