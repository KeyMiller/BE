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
    public class CajaNegocio : ICajaNegocio
    {
        #region declaracion de variables generales
        public readonly ICajaRepositorio _ICajaRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public CajaNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _ICajaRepositorio = new CajaRepositorio();
        }

        public CajaResponse Create(CajaRequest entity)
        {
            Caja cat = _mapper.Map<Caja>(entity);
            cat = _ICajaRepositorio.Create(cat);
            CajaResponse res = _mapper.Map<CajaResponse>(cat);
            return res;
        }

        public List<CajaResponse> CreateMultiple(List<CajaRequest> request)
        {
            List<Caja> cat = _mapper.Map<List<Caja>>(request);
            cat = _ICajaRepositorio.InsertMultiple(cat);
            List<CajaResponse> res = _mapper.Map<List<CajaResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _ICajaRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<CajaRequest> request)
        {
            List<Caja> cat = _mapper.Map<List<Caja>>(request);
            int cantidad = _ICajaRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<CajaResponse> GetAll()
        {
            List<Caja> lst = _ICajaRepositorio.GetAll();
            List<CajaResponse> res = _mapper.Map<List<CajaResponse>>(lst);
            return res;
        }

        public List<CajaResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public CajaResponse GetById(int id)
        {
            Caja cat = _ICajaRepositorio.GetById(id);
            CajaResponse res = _mapper.Map<CajaResponse>(cat);
            return res;
        }

        public CajaResponse Update(CajaRequest entity)
        {
            Caja cat = _mapper.Map<Caja>(entity);
            cat = _ICajaRepositorio.Update(cat);
            CajaResponse res = _mapper.Map<CajaResponse>(cat);
            return res;
        }

        public List<CajaResponse> UpdateMultiple(List<CajaRequest> request)
        {
            List<Caja> cat = _mapper.Map<List<Caja>>(request);
            cat = _ICajaRepositorio.UpdateMultiple(cat);
            List<CajaResponse> res = _mapper.Map<List<CajaResponse>>(cat);
            return res;
        }
    }
}
#endregion