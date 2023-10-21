using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface IMovimientoCajaNegocio : ICRUDNegocio<MovimientoCajaRequest, MovimientoCajaResponse>
    {
        // MovimientoCajaResponse Create(MovimientoCajaRequest entity);
    }


}
