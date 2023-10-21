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
    public class ProductoNegocio : IProductoNegocio
    {
        #region declaracion de variables generales
        public readonly IProductoRepositorio _IProductoRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public ProductoNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IProductoRepositorio = new ProductoRepositorio();
        }

        public ProductoResponse Create(ProductoRequest entity)
        {
            Producto cat = _mapper.Map<Producto>(entity);
            cat = _IProductoRepositorio.Create(cat);
            ProductoResponse res = _mapper.Map<ProductoResponse>(cat);
            return res;
        }

        public List<ProductoResponse> CreateMultiple(List<ProductoRequest> request)
        {
            List<Producto> cat = _mapper.Map<List<Producto>>(request);
            cat = _IProductoRepositorio.InsertMultiple(cat);
            List<ProductoResponse> res = _mapper.Map<List<ProductoResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IProductoRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<ProductoRequest> request)
        {
            List<Producto> cat = _mapper.Map<List<Producto>>(request);
            int cantidad = _IProductoRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ProductoResponse> GetAll()
        {
            List<Producto> lst = _IProductoRepositorio.GetAll();
            List<ProductoResponse> res = _mapper.Map<List<ProductoResponse>>(lst);
            return res;
        }

        public List<ProductoResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public ProductoResponse GetById(int id)
        {
            Producto cat = _IProductoRepositorio.GetById(id);
            ProductoResponse res = _mapper.Map<ProductoResponse>(cat);
            return res;
        }

        public ProductoResponse Update(ProductoRequest entity)
        {
            Producto cat = _mapper.Map<Producto>(entity);
            cat = _IProductoRepositorio.Update(cat);
            ProductoResponse res = _mapper.Map<ProductoResponse>(cat);
            return res;
        }

        public List<ProductoResponse> UpdateMultiple(List<ProductoRequest> request)
        {
            List<Producto> cat = _mapper.Map<List<Producto>>(request);
            cat = _IProductoRepositorio.UpdateMultiple(cat);
            List<ProductoResponse> res = _mapper.Map<List<ProductoResponse>>(cat);
            return res;
        }
    }
}
#endregion