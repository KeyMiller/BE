using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface ICajaNegocio : ICRUDNegocio<CajaRequest, CajaResponse>
    {
        // CajaResponse Create(CajaRequest entity);
    }


}