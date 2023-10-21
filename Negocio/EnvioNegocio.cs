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
    public class EnvioNegocio : IEnvioNegocio
    {
        #region declaracion de variables generales
        public readonly IEnvioRepositorio _IEnvioRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public EnvioNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IEnvioRepositorio = new EnvioRepositorio();
        }

        public EnvioResponse Create(EnvioRequest entity)
        {
            Envio cat = _mapper.Map<Envio>(entity);
            cat = _IEnvioRepositorio.Create(cat);
            EnvioResponse res = _mapper.Map<EnvioResponse>(cat);
            return res;
        }

        public List<EnvioResponse> CreateMultiple(List<EnvioRequest> request)
        {
            List<Envio> cat = _mapper.Map<List<Envio>>(request);
            cat = _IEnvioRepositorio.InsertMultiple(cat);
            List<EnvioResponse> res = _mapper.Map<List<EnvioResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IEnvioRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<EnvioRequest> request)
        {
            List<Envio> cat = _mapper.Map<List<Envio>>(request);
            int cantidad = _IEnvioRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<EnvioResponse> GetAll()
        {
            List<Envio> lst = _IEnvioRepositorio.GetAll();
            List<EnvioResponse> res = _mapper.Map<List<EnvioResponse>>(lst);
            return res;
        }

        public List<EnvioResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public EnvioResponse GetById(int id)
        {
            Envio cat = _IEnvioRepositorio.GetById(id);
            EnvioResponse res = _mapper.Map<EnvioResponse>(cat);
            return res;
        }

        public EnvioResponse Update(EnvioRequest entity)
        {
            Envio cat = _mapper.Map<Envio>(entity);
            cat = _IEnvioRepositorio.Update(cat);
            EnvioResponse res = _mapper.Map<EnvioResponse>(cat);
            return res;
        }

        public List<EnvioResponse> UpdateMultiple(List<EnvioRequest> request)
        {
            List<Envio> cat = _mapper.Map<List<Envio>>(request);
            cat = _IEnvioRepositorio.UpdateMultiple(cat);
            List<EnvioResponse> res = _mapper.Map<List<EnvioResponse>>(cat);
            return res;
        }
    }
}
#endregion