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
    public class PedidoNegocio : IPedidoNegocio
    {
        #region declaracion de variables generales
        public readonly IPedidoRepositorio _IPedidoRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public PedidoNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IPedidoRepositorio = new PedidoRepositorio();
        }
        #endregion
        //Inyeccion de dependencias

        public PedidoResponse Create(PedidoRequest entity)
        {
            /*SiN AUTOMAPPER*/
            /*Pedido cat = new Pedido();

                cat.CodigoPedido = entity.CodigoPedido;
                cat.Tipo = entity.Tipo;
                cat.Descripcion = entity.Descripcion;
                cat.Estado = entity.Estado;
            PedidoResponse res = new PedidoResponse();
            res.CodigoPedido = cat.CodigoPedido;
            res.Tipo = cat.Tipo;
            res.Descripcion = cat.Descripcion;
            res.Estado = cat.Estado;*/

            /*CON AUTOMAPPER*/
            Pedido cat = _mapper.Map<Pedido>(entity);
            cat = _IPedidoRepositorio.Create(cat);
            PedidoResponse res = _mapper.Map<PedidoResponse>(cat);
            return res;
        }

        public List<PedidoResponse> CreateMultiple(List<PedidoRequest> request)
        {
            List<Pedido> cat = _mapper.Map<List<Pedido>>(request);
            cat = _IPedidoRepositorio.InsertMultiple(cat);
            List<PedidoResponse> res = _mapper.Map<List<PedidoResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IPedidoRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<PedidoRequest> request)
        {
            List<Pedido> cat = _mapper.Map<List<Pedido>>(request);
            int cantidad = _IPedidoRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            //limpia de memoria
            GC.SuppressFinalize(this);
        }

        public List<PedidoResponse> GetAll()
        {
            List<Pedido> lst = _IPedidoRepositorio.GetAll();
            List<PedidoResponse> res = _mapper.Map<List<PedidoResponse>>(lst);
            return res;
        }

        public List<PedidoResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public PedidoResponse GetById(int id)
        {
            Pedido cat = _IPedidoRepositorio.GetById(id);
            PedidoResponse res = _mapper.Map<PedidoResponse>(cat);
            return res;
        }

        public PedidoResponse Update(PedidoRequest entity)
        {
            Pedido cat = _mapper.Map<Pedido>(entity);
            cat = _IPedidoRepositorio.Update(cat);
            PedidoResponse res = _mapper.Map<PedidoResponse>(cat);
            return res;
        }

        public List<PedidoResponse> UpdateMultiple(List<PedidoRequest> request)
        {
            List<Pedido> cat = _mapper.Map<List<Pedido>>(request);
            cat = _IPedidoRepositorio.UpdateMultiple(cat);
            List<PedidoResponse> res = _mapper.Map<List<PedidoResponse>>(cat);
            return res;
        }
    }
}
