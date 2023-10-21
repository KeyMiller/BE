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
    public class ComprobanteNegocio : IComprobanteNegocio
    {
        #region declaracion de variables generales
        public readonly IComprobanteRepositorio _IComprobanteRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public ComprobanteNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IComprobanteRepositorio = new ComprobanteRepositorio();
        }
        #endregion
        //Inyeccion de dependencias

        public ComprobanteResponse Create(ComprobanteRequest entity)
        {
            /*SiN AUTOMAPPER*/
            /*Comprobante cat = new Comprobante();

                cat.CodigoComprobante = entity.CodigoComprobante;
                cat.Tipo = entity.Tipo;
                cat.Descripcion = entity.Descripcion;
                cat.Estado = entity.Estado;
            ComprobanteResponse res = new ComprobanteResponse();
            res.CodigoComprobante = cat.CodigoComprobante;
            res.Tipo = cat.Tipo;
            res.Descripcion = cat.Descripcion;
            res.Estado = cat.Estado;*/

            /*CON AUTOMAPPER*/
            Comprobante cat = _mapper.Map<Comprobante>(entity);
            cat = _IComprobanteRepositorio.Create(cat);
            ComprobanteResponse res = _mapper.Map<ComprobanteResponse>(cat);
            return res;
        }

        public List<ComprobanteResponse> CreateMultiple(List<ComprobanteRequest> request)
        {
            List<Comprobante> cat = _mapper.Map<List<Comprobante>>(request);
            cat = _IComprobanteRepositorio.InsertMultiple(cat);
            List<ComprobanteResponse> res = _mapper.Map<List<ComprobanteResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IComprobanteRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<ComprobanteRequest> request)
        {
            List<Comprobante> cat = _mapper.Map<List<Comprobante>>(request);
            int cantidad = _IComprobanteRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            //limpia de memoria
            GC.SuppressFinalize(this);
        }

        public List<ComprobanteResponse> GetAll()
        {
            List<Comprobante> lst = _IComprobanteRepositorio.GetAll();
            List<ComprobanteResponse> res = _mapper.Map<List<ComprobanteResponse>>(lst);
            return res;
        }

        public List<ComprobanteResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public ComprobanteResponse GetById(int id)
        {
            Comprobante cat = _IComprobanteRepositorio.GetById(id);
            ComprobanteResponse res = _mapper.Map<ComprobanteResponse>(cat);
            return res;
        }

        public ComprobanteResponse Update(ComprobanteRequest entity)
        {
            Comprobante cat = _mapper.Map<Comprobante>(entity);
            cat = _IComprobanteRepositorio.Update(cat);
            ComprobanteResponse res = _mapper.Map<ComprobanteResponse>(cat);
            return res;
        }

        public List<ComprobanteResponse> UpdateMultiple(List<ComprobanteRequest> request)
        {
            List<Comprobante> cat = _mapper.Map<List<Comprobante>>(request);
            cat = _IComprobanteRepositorio.UpdateMultiple(cat);
            List<ComprobanteResponse> res = _mapper.Map<List<ComprobanteResponse>>(cat);
            return res;
        }
    }
}
