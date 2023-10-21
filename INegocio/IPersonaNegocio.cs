using Models.RequestResponse;
using UtilInterface;

namespace INegocio
{
    public interface IPersonaNegocio : ICRUDNegocio<PersonaRequest, PersonaResponse>
    {
        // CategoriaResponse Create(CategoriaRequest entity);
    }


}