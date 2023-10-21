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
    public class TipoPagoNegocio : ITipoPagoNegocio
    {
        #region declaracion de variables generales
        public readonly ITipoPagoRepositorio _ITipoPagoRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public TipoPagoNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _ITipoPagoRepositorio = new TipoPagoRepositorio();
        }

        public TipoPagoResponse Create(TipoPagoRequest entity)
        {
            Tipopago cat = _mapper.Map<Tipopago>(entity);
            cat = _ITipoPagoRepositorio.Create(cat);
            TipoPagoResponse res = _mapper.Map<TipoPagoResponse>(cat);
            return res;
        }

        public List<TipoPagoResponse> CreateMultiple(List<TipoPagoRequest> request)
        {
            List<Tipopago> cat = _mapper.Map<List<Tipopago>>(request);
            cat = _ITipoPagoRepositorio.InsertMultiple(cat);
            List<TipoPagoResponse> res = _mapper.Map<List<TipoPagoResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _ITipoPagoRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<TipoPagoRequest> request)
        {
            List<Tipopago> cat = _mapper.Map<List<Tipopago>>(request);
            int cantidad = _ITipoPagoRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<TipoPagoResponse> GetAll()
        {
            List<Tipopago> lst = _ITipoPagoRepositorio.GetAll();
            List<TipoPagoResponse> res = _mapper.Map<List<TipoPagoResponse>>(lst);
            return res;
        }

        public List<TipoPagoResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public TipoPagoResponse GetById(int id)
        {
            Tipopago cat = _ITipoPagoRepositorio.GetById(id);
            TipoPagoResponse res = _mapper.Map<TipoPagoResponse>(cat);
            return res;
        }

        public TipoPagoResponse Update(TipoPagoRequest entity)
        {
            Tipopago cat = _mapper.Map<Tipopago>(entity);
            cat = _ITipoPagoRepositorio.Update(cat);
            TipoPagoResponse res = _mapper.Map<TipoPagoResponse>(cat);
            return res;
        }

        public List<TipoPagoResponse> UpdateMultiple(List<TipoPagoRequest> request)
        {
            List<Tipopago> cat = _mapper.Map<List<Tipopago>>(request);
            cat = _ITipoPagoRepositorio.UpdateMultiple(cat);
            List<TipoPagoResponse> res = _mapper.Map<List<TipoPagoResponse>>(cat);
            return res;
        }
    }
}
#endregion