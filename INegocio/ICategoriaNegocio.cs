using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface ICategoriaNegocio : ICRUDNegocio<CategoriaRequest, CategoriaResponse>
    {
       // CategoriaResponse Create(CategoriaRequest entity);
    }


}