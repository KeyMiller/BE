using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface ITipoDocumentoNegocio : ICRUDNegocio<TipoDocumentoRequest, TipoDocumentoResponse>
    {
        // CategoriaResponse Create(CategoriaRequest entity);
    }


}