using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface ITipoPagoNegocio : ICRUDNegocio<TipoPagoRequest, TipoPagoResponse>
    {
        // TipoPagoResponse Create(TipoPagoRequest entity);
    }


}