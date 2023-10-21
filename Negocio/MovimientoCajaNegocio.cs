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
    public class MovimientoCajaNegocio : IMovimientoCajaNegocio
    {
        #region declaracion de variables generales
        public readonly IMovimientoCajaRepositorio _IMovimientoCajaRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public MovimientoCajaNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IMovimientoCajaRepositorio = new MovimientoCajaRepositorio();
        }

        public MovimientoCajaResponse Create(MovimientoCajaRequest entity)
        {
            Movimientocaja cat = _mapper.Map<Movimientocaja>(entity);
            cat = _IMovimientoCajaRepositorio.Create(cat);
            MovimientoCajaResponse res = _mapper.Map<MovimientoCajaResponse>(cat);
            return res;
        }

        public List<MovimientoCajaResponse> CreateMultiple(List<MovimientoCajaRequest> request)
        {
            List<Movimientocaja> cat = _mapper.Map<List<Movimientocaja>>(request);
            cat = _IMovimientoCajaRepositorio.InsertMultiple(cat);
            List<MovimientoCajaResponse> res = _mapper.Map<List<MovimientoCajaResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IMovimientoCajaRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<MovimientoCajaRequest> request)
        {
            List<Movimientocaja> cat = _mapper.Map<List<Movimientocaja>>(request);
            int cantidad = _IMovimientoCajaRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<MovimientoCajaResponse> GetAll()
        {
            List<Movimientocaja> lst = _IMovimientoCajaRepositorio.GetAll();
            List<MovimientoCajaResponse> res = _mapper.Map<List<MovimientoCajaResponse>>(lst);
            return res;
        }

        public List<MovimientoCajaResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public MovimientoCajaResponse GetById(int id)
        {
            Movimientocaja cat = _IMovimientoCajaRepositorio.GetById(id);
            MovimientoCajaResponse res = _mapper.Map<MovimientoCajaResponse>(cat);
            return res;
        }

        public MovimientoCajaResponse Update(MovimientoCajaRequest entity)
        {
            Movimientocaja cat = _mapper.Map<Movimientocaja>(entity);
            cat = _IMovimientoCajaRepositorio.Update(cat);
            MovimientoCajaResponse res = _mapper.Map<MovimientoCajaResponse>(cat);
            return res;
        }

        public List<MovimientoCajaResponse> UpdateMultiple(List<MovimientoCajaRequest> request)
        {
            List<Movimientocaja> cat = _mapper.Map<List<Movimientocaja>>(request);
            cat = _IMovimientoCajaRepositorio.UpdateMultiple(cat);
            List<MovimientoCajaResponse> res = _mapper.Map<List<MovimientoCajaResponse>>(cat);
            return res;
        }
    }
}
#endregion