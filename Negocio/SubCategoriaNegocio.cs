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
    public class SubCategoriaNegocio : ISubCategoriaNegocio
    {
        #region declaracion de variables generales
        public readonly ISubCategoriaRepositorio _ISubCategoriaRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public SubCategoriaNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _ISubCategoriaRepositorio = new SubCategoriaRepositorio();
        }
        #endregion
        //Inyeccion de dependencias

        public SubCategoriaResponse Create(SubCategoriaRequest entity)
        {
            /*SiN AUTOMAPPER*/
            /*SubCategoria cat = new SubCategoria();

                cat.CodigoSubCategoria = entity.CodigoSubCategoria;
                cat.Tipo = entity.Tipo;
                cat.Descripcion = entity.Descripcion;
                cat.Estado = entity.Estado;
            SubCategoriaResponse res = new SubCategoriaResponse();
            res.CodigoSubCategoria = cat.CodigoSubCategoria;
            res.Tipo = cat.Tipo;
            res.Descripcion = cat.Descripcion;
            res.Estado = cat.Estado;*/

            /*CON AUTOMAPPER*/
            Subcategoria cat = _mapper.Map<Subcategoria>(entity);
            cat = _ISubCategoriaRepositorio.Create(cat);
            SubCategoriaResponse res = _mapper.Map<SubCategoriaResponse>(cat);
            return res;
        }

        public List<SubCategoriaResponse> CreateMultiple(List<SubCategoriaRequest> request)
        {
            List<Subcategoria> cat = _mapper.Map<List<Subcategoria>>(request);
            cat = _ISubCategoriaRepositorio.InsertMultiple(cat);
            List<SubCategoriaResponse> res = _mapper.Map<List<SubCategoriaResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _ISubCategoriaRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<SubCategoriaRequest> request)
        {
            List<Subcategoria> cat = _mapper.Map<List<Subcategoria>>(request);
            int cantidad = _ISubCategoriaRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            //limpia de memoria
            GC.SuppressFinalize(this);
        }

        public List<SubCategoriaResponse> GetAll()
        {
            List<Subcategoria> lst = _ISubCategoriaRepositorio.GetAll();
            List<SubCategoriaResponse> res = _mapper.Map<List<SubCategoriaResponse>>(lst);
            return res;
        }

        public List<SubCategoriaResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public SubCategoriaResponse GetById(int id)
        {
            Subcategoria cat = _ISubCategoriaRepositorio.GetById(id);
            SubCategoriaResponse res = _mapper.Map<SubCategoriaResponse>(cat);
            return res;
        }

        public SubCategoriaResponse Update(SubCategoriaRequest entity)
        {
            Subcategoria cat = _mapper.Map<Subcategoria>(entity);
            cat = _ISubCategoriaRepositorio.Update(cat);
            SubCategoriaResponse res = _mapper.Map<SubCategoriaResponse>(cat);
            return res;
        }

        public List<SubCategoriaResponse> UpdateMultiple(List<SubCategoriaRequest> request)
        {
            List<Subcategoria> cat = _mapper.Map<List<Subcategoria>>(request);
            cat = _ISubCategoriaRepositorio.UpdateMultiple(cat);
            List<SubCategoriaResponse> res = _mapper.Map<List<SubCategoriaResponse>>(cat);
            return res;
        }
    }
}
