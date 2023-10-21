using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface IColaboradorNegocio : ICRUDNegocio<ColaboradorRequest, ColaboradorResponse>
    {
        // ColaboradorResponse Create(ColaboradorRequest entity);
    }


}