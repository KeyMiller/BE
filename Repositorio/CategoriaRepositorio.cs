using DBModel.DBBodega;
using IRepositorio;
using Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class CategoriaRepositorio : GenericRepository<Categoria>, ICategoriaRepositorio
    {
        public List<Categoria> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }
    }

}
