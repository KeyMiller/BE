using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface IPagoNegocio : ICRUDNegocio<PagoRequest, PagoResponse>
    {
        // PagoResponse Create(PagoRequest entity);
    }


}