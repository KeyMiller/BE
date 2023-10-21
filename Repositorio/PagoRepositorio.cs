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
    public class PagoRepositorio : GenericRepository<Pago>, IRepositorio.IPagoRepositorio
    {

        public List<Pago> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }


    }
}
