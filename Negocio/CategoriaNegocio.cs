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
    public class CategoriaNegocio : ICategoriaNegocio
    {
        #region declaracion de variables generales
        public readonly ICategoriaRepositorio _ICategoriaRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public CategoriaNegocio(IMapper mapper){
            _mapper = mapper;
            _ICategoriaRepositorio = new CategoriaRepositorio();
        }
        #endregion
        //Inyeccion de dependencias

        public CategoriaResponse Create(CategoriaRequest entity)
        {
            /*SiN AUTOMAPPER*/
            /*Categoria cat = new Categoria();

                cat.CodigoCategoria = entity.CodigoCategoria;
                cat.Tipo = entity.Tipo;
                cat.Descripcion = entity.Descripcion;
                cat.Estado = entity.Estado;
            CategoriaResponse res = new CategoriaResponse();
            res.CodigoCategoria = cat.CodigoCategoria;
            res.Tipo = cat.Tipo;
            res.Descripcion = cat.Descripcion;
            res.Estado = cat.Estado;*/
            
            /*CON AUTOMAPPER*/
            Categoria cat = _mapper.Map<Categoria>(entity);
            cat=_ICategoriaRepositorio.Create(cat);
            CategoriaResponse res= _mapper.Map<CategoriaResponse>(cat);
            return res;
        }

        public List<CategoriaResponse> CreateMultiple(List<CategoriaRequest> request)
        {
            List<Categoria> cat = _mapper.Map<List<Categoria>>(request);
            cat = _ICategoriaRepositorio.InsertMultiple(cat);
            List<CategoriaResponse> res = _mapper.Map<List<CategoriaResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _ICategoriaRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<CategoriaRequest> request)
        {
            List<Categoria> cat = _mapper.Map<List<Categoria>>(request);
            int cantidad = _ICategoriaRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            //limpia de memoria
            GC.SuppressFinalize(this);
        }

        public List<CategoriaResponse> GetAll()
        {
            List<Categoria> lst = _ICategoriaRepositorio.GetAll();
            List<CategoriaResponse> res = _mapper.Map<List<CategoriaResponse>>(lst);
            return res;
        }

        public List<CategoriaResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public CategoriaResponse GetById(int id)
        {
           Categoria cat = _ICategoriaRepositorio.GetById(id);
           CategoriaResponse res = _mapper.Map<CategoriaResponse>(cat);
            return res;
        }

        public CategoriaResponse Update(CategoriaRequest entity)
        {
            Categoria cat = _mapper.Map<Categoria>(entity);
            cat = _ICategoriaRepositorio.Update(cat);
            CategoriaResponse res = _mapper.Map<CategoriaResponse>(cat);
            return res;
        }

        public List<CategoriaResponse> UpdateMultiple(List<CategoriaRequest> request)
        {
            List<Categoria> cat = _mapper.Map<List<Categoria>>(request);
            cat = _ICategoriaRepositorio.UpdateMultiple(cat);
            List<CategoriaResponse> res = _mapper.Map<List<CategoriaResponse>>(cat);
            return res;
        }
    }
}
