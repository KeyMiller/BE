using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface IProductoNegocio : ICRUDNegocio<ProductoRequest, ProductoResponse>
    {
        // ProductoResponse Create(ProductoRequest entity);
    }


}