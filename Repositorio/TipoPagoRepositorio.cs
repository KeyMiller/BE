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
    public class TipoPagoRepositorio : GenericRepository<Tipopago>, ITipoPagoRepositorio
    {

        public List<Tipopago> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }


    }
}


