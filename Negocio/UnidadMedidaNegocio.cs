using AutoMapper;
using DBModel.DBBodega;
using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Vml.Office;
using INegocio;
using IRepositorio;
using Models.RequestResponse;
using Repositorio;
using UtilInterface;

namespace Negocio
{
    public class UnidadMedidaNegocio : IUnidadMedidaNegocio
    {
        #region declaracion de variables generales
        public readonly IUnidadMedidaRepositorio _IUnidadMedidaRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public UnidadMedidaNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IUnidadMedidaRepositorio = new UnidadMedidaRepositorio();
        }

        public UnidadMedidaResponse Create(UnidadMedidaRequest entity)
        {
            Unidadmedida cat = _mapper.Map<Unidadmedida>(entity);
            cat = _IUnidadMedidaRepositorio.Create(cat);
            UnidadMedidaResponse res = _mapper.Map<UnidadMedidaResponse>(cat);
            return res;
        }

        public List<UnidadMedidaResponse> CreateMultiple(List<UnidadMedidaRequest> request)
        {
            List<Unidadmedida> cat = _mapper.Map<List<Unidadmedida>>(request);
            cat = _IUnidadMedidaRepositorio.InsertMultiple(cat);
            List<UnidadMedidaResponse> res = _mapper.Map<List<UnidadMedidaResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IUnidadMedidaRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<UnidadMedidaRequest> request)
        {
            List<Unidadmedida> cat = _mapper.Map<List<Unidadmedida>>(request);
            int cantidad = _IUnidadMedidaRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<UnidadMedidaResponse> GetAll()
        {
            List<Unidadmedida> lst = _IUnidadMedidaRepositorio.GetAll();
            List<UnidadMedidaResponse> res = _mapper.Map<List<UnidadMedidaResponse>>(lst);
            return res;
        }

        public List<UnidadMedidaResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public UnidadMedidaResponse GetById(int id)
        {
            Unidadmedida cat = _IUnidadMedidaRepositorio.GetById(id);
            UnidadMedidaResponse res = _mapper.Map<UnidadMedidaResponse>(cat);
            return res;
        }

        public UnidadMedidaResponse Update(UnidadMedidaRequest entity)
        {
            Unidadmedida cat = _mapper.Map<Unidadmedida>(entity);
            cat = _IUnidadMedidaRepositorio.Update(cat);
            UnidadMedidaResponse res = _mapper.Map<UnidadMedidaResponse>(cat);
            return res;
        }

        public List<UnidadMedidaResponse> UpdateMultiple(List<UnidadMedidaRequest> request)
        {
            List<Unidadmedida> cat = _mapper.Map<List<Unidadmedida>>(request);
            cat = _IUnidadMedidaRepositorio.UpdateMultiple(cat);
            List<UnidadMedidaResponse> res = _mapper.Map<List<UnidadMedidaResponse>>(cat);
            return res;
        }
    }
}
#endregion