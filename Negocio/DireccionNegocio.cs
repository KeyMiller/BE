using AutoMapper;
using DBModel.DBBodega;
using INegocio;
using IRepositorio;
using Models.RequestResponse;
using Repositorio;
namespace Negocio
{
    public class DireccionNegocio : IDireccionNegocio
    {
        #region declaracion variables generales
        public readonly IDireccionRepositorio _IDireccionRepositorio = null;
        public readonly IMapper _mapper;
        #endregion

        #region constructor
        public DireccionNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IDireccionRepositorio = new DireccionRepositorio();
        }
        #endregion
        public DireccionResponse Create(DireccionRequest entity)
        {
            Direccione cat = _mapper.Map<Direccione>(entity);
            cat = _IDireccionRepositorio.Create(cat);
            DireccionResponse res = _mapper.Map<DireccionResponse>(cat);
            return res;
        }

        public List<DireccionResponse> CreateMultiple(List<DireccionRequest> request)
        {
            List<Direccione> cat = _mapper.Map<List<Direccione>>(request);
            cat = _IDireccionRepositorio.InsertMultiple(cat);
            List<DireccionResponse> res = _mapper.Map<List<DireccionResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IDireccionRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<DireccionRequest> request)
        {
            List<Direccione> cat = _mapper.Map<List<Direccione>>(request);
            int cantidad = _IDireccionRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<DireccionResponse> GetAll()
        {

            List<Direccione> lst = _IDireccionRepositorio.GetAll();
            List<DireccionResponse> res = _mapper.Map<List<DireccionResponse>>(lst);
            return res;
        }

        public List<DireccionResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public DireccionResponse GetById(int id)
        {
            Direccione cat = _IDireccionRepositorio.GetById(id);
            DireccionResponse res = _mapper.Map<DireccionResponse>(cat);
            return res;
        }

        public DireccionResponse Update(DireccionRequest entity)
        {
            Direccione cat = _mapper.Map<Direccione>(entity);
            cat = _IDireccionRepositorio.Update(cat);
            DireccionResponse res = _mapper.Map<DireccionResponse>(cat);
            return res;
        }

        public List<DireccionResponse> UpdateMultiple(List<DireccionRequest> request)
        {
            List<Direccione> cat = _mapper.Map<List<Direccione>>(request);
            cat = _IDireccionRepositorio.UpdateMultiple(cat);
            List<DireccionResponse> res = _mapper.Map<List<DireccionResponse>>(cat);
            return res;
        }
    }
}