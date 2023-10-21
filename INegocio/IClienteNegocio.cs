using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface IClienteNegocio : ICRUDNegocio<ClienteRequest, ClienteResponse>
    {
        // CategoriaResponse Create(CategoriaRequest entity);
    }


}