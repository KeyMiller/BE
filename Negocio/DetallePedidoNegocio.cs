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
    public class DetallePedidoNegocio : IDetallePedidoNegocio
    {
        #region declaracion de variables generales
        public readonly IDetallePedidoRepositorio _IDetallePedidoRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public DetallePedidoNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IDetallePedidoRepositorio = new DetallePedidoRepositorio();
        }
        #endregion
        //Inyeccion de dependencias

        public DetallePedidoResponse Create(DetallePedidoRequest entity)
        {
            /*SiN AUTOMAPPER*/
            /*DetallePedido cat = new DetallePedido();

                cat.CodigoDetallePedido = entity.CodigoDetallePedido;
                cat.Tipo = entity.Tipo;
                cat.Descripcion = entity.Descripcion;
                cat.Estado = entity.Estado;
            DetallePedidoResponse res = new DetallePedidoResponse();
            res.CodigoDetallePedido = cat.CodigoDetallePedido;
            res.Tipo = cat.Tipo;
            res.Descripcion = cat.Descripcion;
            res.Estado = cat.Estado;*/

            /*CON AUTOMAPPER*/
            Detallepedido cat = _mapper.Map<Detallepedido>(entity);
            cat = _IDetallePedidoRepositorio.Create(cat);
            DetallePedidoResponse res = _mapper.Map<DetallePedidoResponse>(cat);
            return res;
        }

        public List<DetallePedidoResponse> CreateMultiple(List<DetallePedidoRequest> request)
        {
            List<Detallepedido> cat = _mapper.Map<List<Detallepedido>>(request);
            cat = _IDetallePedidoRepositorio.InsertMultiple(cat);
            List<DetallePedidoResponse> res = _mapper.Map<List<DetallePedidoResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IDetallePedidoRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<DetallePedidoRequest> request)
        {
            List<Detallepedido> cat = _mapper.Map<List<Detallepedido>>(request);
            int cantidad = _IDetallePedidoRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            //limpia de memoria
            GC.SuppressFinalize(this);
        }

        public List<DetallePedidoResponse> GetAll()
        {
            List<Detallepedido> lst = _IDetallePedidoRepositorio.GetAll();
            List<DetallePedidoResponse> res = _mapper.Map<List<DetallePedidoResponse>>(lst);
            return res;
        }

        public List<DetallePedidoResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public DetallePedidoResponse GetById(int id)
        {
            Detallepedido cat = _IDetallePedidoRepositorio.GetById(id);
            DetallePedidoResponse res = _mapper.Map<DetallePedidoResponse>(cat);
            return res;
        }

        public DetallePedidoResponse Update(DetallePedidoRequest entity)
        {
            Detallepedido cat = _mapper.Map<Detallepedido>(entity);
            cat = _IDetallePedidoRepositorio.Update(cat);
            DetallePedidoResponse res = _mapper.Map<DetallePedidoResponse>(cat);
            return res;
        }

        public List<DetallePedidoResponse> UpdateMultiple(List<DetallePedidoRequest> request)
        {
            List<Detallepedido> cat = _mapper.Map<List<Detallepedido>>(request);
            cat = _IDetallePedidoRepositorio.UpdateMultiple(cat);
            List<DetallePedidoResponse> res = _mapper.Map<List<DetallePedidoResponse>>(cat);
            return res;
        }
    }
}
