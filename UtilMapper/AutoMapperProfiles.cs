using AutoMapper;
using DBModel.DBBodega;
using Models;
using Models.RequestResponse;


namespace UtilMapper
{
    //dar un poco mas de enfasis en lo que respecta al auto mapper
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Categoria, CategoriaRequest>().ReverseMap();
            CreateMap<Categoria, CategoriaResponse>().ReverseMap();

            CreateMap<Colaborativo, ColaboradorRequest>().ReverseMap();
            CreateMap<Colaborativo, ColaboradorResponse>().ReverseMap();

            CreateMap<Tipodocumento, TipoDocumentoRequest>().ReverseMap();
            CreateMap<Tipodocumento, TipoDocumentoResponse>().ReverseMap();

            CreateMap<Direccione, DireccionRequest>().ReverseMap();
            CreateMap<Direccione, DireccionResponse>().ReverseMap();

            CreateMap<Subcategoria, SubCategoriaRequest>().ReverseMap();
            CreateMap<Subcategoria, SubCategoriaResponse>().ReverseMap();

            CreateMap<Comprobante, ComprobanteRequest>().ReverseMap();
            CreateMap<Comprobante, ComprobanteResponse>().ReverseMap();

            CreateMap<Unidadmedida, UnidadMedidaRequest>().ReverseMap();
            CreateMap<Unidadmedida, UnidadMedidaResponse>().ReverseMap();

            CreateMap<Persona, PersonaRequest>().ReverseMap();
            CreateMap<Persona, PersonaResponse>().ReverseMap();

            CreateMap<Cliente, ClienteRequest>().ReverseMap();
            CreateMap<Cliente, ClienteResponse>().ReverseMap();

            CreateMap<Cargocolaborativo, CargoColaborativoRequest>().ReverseMap();
            CreateMap<Cargocolaborativo, CargoColaborativoResponse>().ReverseMap();

            CreateMap<Tipopago, TipoPagoRequest>().ReverseMap();
            CreateMap<Tipopago, TipoPagoResponse>().ReverseMap();

            CreateMap<Pago, PagoRequest>().ReverseMap();
            CreateMap<Pago, PagoResponse>().ReverseMap();

            CreateMap<Envio, EnvioRequest>().ReverseMap();
            CreateMap<Envio, EnvioResponse>().ReverseMap();

            CreateMap<Producto, ProductoRequest>().ReverseMap();
            CreateMap<Producto, ProductoResponse>().ReverseMap();

            CreateMap<Pedido, PedidoRequest>().ReverseMap();
            CreateMap<Pedido, PedidoResponse>().ReverseMap();

            CreateMap<Caja, CajaRequest>().ReverseMap();
            CreateMap<Caja, CajaResponse>().ReverseMap();

            CreateMap<Movimientocaja, MovimientoCajaRequest>().ReverseMap();
            CreateMap<Movimientocaja, MovimientoCajaResponse>().ReverseMap();

            CreateMap<Usuario, UsuarioRequest>().ReverseMap();
            CreateMap<Usuario, UsuarioResponse>().ReverseMap();
        }

    }
}