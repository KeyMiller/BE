using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface IDetallePedidoNegocio : ICRUDNegocio<DetallePedidoRequest, DetallePedidoResponse>
    {
        // DetallePedidoResponse Create(DetallePedidoRequest entity);
    }


}