using AutoMapper;
using DBModel.DBBodega;
using DocumentFormat.OpenXml.Office2016.Excel;
using INegocio;
using IRepositorio;
using Models.RequestResponse;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio:IClienteNegocio
    {
        #region declaracion de variables generales
        public readonly IClienteRepositorio _IClienteRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public ClienteNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IClienteRepositorio = new ClienteRepositorio();
        }

        public ClienteResponse Create(ClienteRequest entity)
        {
            Cliente cat = _mapper.Map<Cliente>(entity);
            cat = _IClienteRepositorio.Create(cat);
            ClienteResponse res = _mapper.Map<ClienteResponse>(cat);
            return res;
        }

        public List<ClienteResponse> CreateMultiple(List<ClienteRequest>request)
        {
            List<Cliente> cat = _mapper.Map<List<Cliente>>(request);
            cat = _IClienteRepositorio.InsertMultiple(cat);
            List<ClienteResponse> res = _mapper.Map<List<ClienteResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IClienteRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<ClienteRequest> request)
        {
            List<Cliente> cat = _mapper.Map<List<Cliente>>(request);
            int cantidad = _IClienteRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ClienteResponse> GetAll()
        {
            List<Cliente> lst = _IClienteRepositorio.GetAll();
            List<ClienteResponse> res = _mapper.Map<List<ClienteResponse>>(lst);
            return res;
        }

        public List<ClienteResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public ClienteResponse GetById(int id)
        {
            Cliente cat = _IClienteRepositorio.GetById(id);
            ClienteResponse res = _mapper.Map<ClienteResponse>(cat);
            return res;
        }

        public ClienteResponse Update(ClienteRequest entity)
        {
            Cliente cat = _mapper.Map<Cliente>(entity);
            cat = _IClienteRepositorio.Update(cat);
            ClienteResponse res = _mapper.Map<ClienteResponse>(cat);
            return res;
        }

        public List<ClienteResponse> UpdateMultiple(List<ClienteRequest> request)
        {
            List<Cliente> cat = _mapper.Map<List<Cliente>>(request);
            cat = _IClienteRepositorio.UpdateMultiple(cat);
            List<ClienteResponse> res = _mapper.Map<List<ClienteResponse>>(cat);
            return res;
        }
    }
}
#endregion