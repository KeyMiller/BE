using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface IEnvioNegocio : ICRUDNegocio<EnvioRequest, EnvioResponse>
    {
        // CategoriaResponse Create(CategoriaRequest entity);
    }


}