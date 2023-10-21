using AutoMapper;
using DBModel.DBBodega;
using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Vml.Office;
using INegocio;
using IRepositorio;
using Models.RequestResponse;
using Repositorio;

namespace Negocio
{
    public class ColaboradorNegocio : IColaboradorNegocio
    {
        #region declaracion de variables generales
        public readonly IColaboradorRepositorio _IColaboradorRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public ColaboradorNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IColaboradorRepositorio = new ColaboradorRepositorio();
        }
        #endregion
        //Inyeccion de dependencias

        public ColaboradorResponse Create(ColaboradorRequest entity)
        {
            Colaborativo cat = _mapper.Map<Colaborativo>(entity);
            cat = _IColaboradorRepositorio.Create(cat);
            ColaboradorResponse res = _mapper.Map<ColaboradorResponse>(cat);
            return res;
        }

        public List<ColaboradorResponse> CreateMultiple(List<ColaboradorRequest> request)
        {
            List<Colaborativo> cat = _mapper.Map<List<Colaborativo>>(request);
            cat = _IColaboradorRepositorio.InsertMultiple(cat);
            List<ColaboradorResponse> res = _mapper.Map<List<ColaboradorResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IColaboradorRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<ColaboradorRequest> request)
        {
            List<Colaborativo> cat = _mapper.Map<List<Colaborativo>>(request);
            int cantidad = _IColaboradorRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            //limpia de memoria
            GC.SuppressFinalize(this);
        }

        public List<ColaboradorResponse> GetAll()
        {
            List<Colaborativo> lst = _IColaboradorRepositorio.GetAll();
            List<ColaboradorResponse> res = _mapper.Map<List<ColaboradorResponse>>(lst);
            return res;
        }


        public List<ColaboradorResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public ColaboradorResponse GetById(int id)
        {
            Colaborativo cat = _IColaboradorRepositorio.GetById(id);
            ColaboradorResponse res = _mapper.Map<ColaboradorResponse>(cat);
            return res;
        }

        public ColaboradorResponse Update(ColaboradorRequest entity)
        {
            Colaborativo cat = _mapper.Map<Colaborativo>(entity);
            cat = _IColaboradorRepositorio.Update(cat);
            ColaboradorResponse res = _mapper.Map<ColaboradorResponse>(cat);
            return res;
        }

        public List<ColaboradorResponse> UpdateMultiple(List<ColaboradorRequest> request)
        {
            List<Colaborativo> cat = _mapper.Map<List<Colaborativo>>(request);
            cat = _IColaboradorRepositorio.UpdateMultiple(cat);
            List<ColaboradorResponse> res = _mapper.Map<List<ColaboradorResponse>>(cat);
            return res;
        }
    }
}
