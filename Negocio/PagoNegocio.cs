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
    public class PagoNegocio : IPagoNegocio
    {
        #region declaracion de variables generales
        public readonly IRepositorio.IPagoRepositorio _IPagoRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public PagoNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IPagoRepositorio = new Repositorio.PagoRepositorio();
        }

        public PagoResponse Create(PagoRequest entity)
        {
            Pago cat = _mapper.Map<Pago>(entity);
            cat = _IPagoRepositorio.Create(cat);
            PagoResponse res = _mapper.Map<PagoResponse>(cat);
            return res;
        }

        public List<PagoResponse> CreateMultiple(List<PagoRequest> request)
        {
            List<Pago> cat = _mapper.Map<List<Pago>>(request);
            cat = _IPagoRepositorio.InsertMultiple(cat);
            List<PagoResponse> res = _mapper.Map<List<PagoResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IPagoRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<PagoRequest> request)
        {
            List<Pago> cat = _mapper.Map<List<Pago>>(request);
            int cantidad = _IPagoRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<PagoResponse> GetAll()
        {
            List<Pago> lst = _IPagoRepositorio.GetAll();
            List<PagoResponse> res = _mapper.Map<List<PagoResponse>>(lst);
            return res;
        }

        public List<PagoResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public PagoResponse GetById(int id)
        {
            Pago cat = _IPagoRepositorio.GetById(id);
            PagoResponse res = _mapper.Map<PagoResponse>(cat);
            return res;
        }

        public PagoResponse Update(PagoRequest entity)
        {
            Pago cat = _mapper.Map<Pago>(entity);
            cat = _IPagoRepositorio.Update(cat);
            PagoResponse res = _mapper.Map<PagoResponse>(cat);
            return res;
        }

        public List<PagoResponse> UpdateMultiple(List<PagoRequest> request)
        {
            List<Pago> cat = _mapper.Map<List<Pago>>(request);
            cat = _IPagoRepositorio.UpdateMultiple(cat);
            List<PagoResponse> res = _mapper.Map<List<PagoResponse>>(cat);
            return res;
        }
    }
}
#endregion