using Models.RequestResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INegocio
{
    public interface IAuthNegocio : IDisposable
    {
        LoginResponse login(LoginRequest request);
    }
}
