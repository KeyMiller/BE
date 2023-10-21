using DBModel.DBBodega;
using UtilInterface;

namespace IRepositorio
{
    public interface IUsuarioRepositorio : ICRUDRepositorio<Usuario>
    {
 
         Usuario GetByUserName(string userName);
    }
   
}