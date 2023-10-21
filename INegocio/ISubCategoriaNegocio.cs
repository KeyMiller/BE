using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface ISubCategoriaNegocio : ICRUDNegocio<SubCategoriaRequest, SubCategoriaResponse>
    {
        // CategoriaResponse Create(CategoriaRequest entity);
    }


}