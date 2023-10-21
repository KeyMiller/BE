using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface IPedidoNegocio : ICRUDNegocio<PedidoRequest, PedidoResponse>
    {
        // PedidoResponse Create(PedidoRequest entity);
    }


}