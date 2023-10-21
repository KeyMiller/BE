using DBModel.DBBodega;
using IRepositorio;
using Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilInterface;

namespace Repositorio
{
    public class ColaboradorRepositorio : GenericRepository<Colaborativo>, IColaboradorRepositorio
    {

        public List<Colaborativo> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public Colaborativo GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}


