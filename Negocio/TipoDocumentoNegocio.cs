using AutoMapper;
using DBModel.DBBodega;
using INegocio;
using IRepositorio;
using Models.RequestResponse;
using Repositorio;
namespace Negocio
{
    public class TipoDocumentoNegocio : ITipoDocumentoNegocio
    {
        #region declaracion variables generales
        public readonly ITipoDocumentoRepositorio _ITipoDocumentoRepositorio = null;
        public readonly IMapper _mapper;
        #endregion

        #region constructor
        public TipoDocumentoNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _ITipoDocumentoRepositorio = new TipoDocumentoRepositorio();
        }
        #endregion
        public TipoDocumentoResponse Create(TipoDocumentoRequest entity)
        {
            Tipodocumento cat = _mapper.Map<Tipodocumento>(entity);
            cat = _ITipoDocumentoRepositorio.Create(cat);
            TipoDocumentoResponse res = _mapper.Map<TipoDocumentoResponse>(cat);
            return res;
        }

        public List<TipoDocumentoResponse> CreateMultiple(List<TipoDocumentoRequest> request)
        {
            List<Tipodocumento> cat = _mapper.Map<List<Tipodocumento>>(request);
            cat = _ITipoDocumentoRepositorio.InsertMultiple(cat);
            List<TipoDocumentoResponse> res = _mapper.Map<List<TipoDocumentoResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _ITipoDocumentoRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<TipoDocumentoRequest> request)
        {
            List<Tipodocumento> cat = _mapper.Map<List<Tipodocumento>>(request);
            int cantidad = _ITipoDocumentoRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<TipoDocumentoResponse> GetAll()
        {

            List<Tipodocumento> lst = _ITipoDocumentoRepositorio.GetAll();
            List<TipoDocumentoResponse> res = _mapper.Map<List<TipoDocumentoResponse>>(lst);
            return res;
        }

        public List<TipoDocumentoResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public TipoDocumentoResponse GetById(int id)
        {
            Tipodocumento cat = _ITipoDocumentoRepositorio.GetById(id);
            TipoDocumentoResponse res = _mapper.Map<TipoDocumentoResponse>(cat);
            return res;
        }

        public TipoDocumentoResponse Update(TipoDocumentoRequest entity)
        {
            Tipodocumento cat = _mapper.Map<Tipodocumento>(entity);
            cat = _ITipoDocumentoRepositorio.Update(cat);
            TipoDocumentoResponse res = _mapper.Map<TipoDocumentoResponse>(cat);
            return res;
        }

        public List<TipoDocumentoResponse> UpdateMultiple(List<TipoDocumentoRequest> request)
        {
            List<Tipodocumento> cat = _mapper.Map<List<Tipodocumento>>(request);
            cat = _ITipoDocumentoRepositorio.UpdateMultiple(cat);
            List<TipoDocumentoResponse> res = _mapper.Map<List<TipoDocumentoResponse>>(cat);
            return res;
        }
    }
}