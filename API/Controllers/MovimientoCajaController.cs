using AutoMapper;
using INegocio;
using Microsoft.AspNetCore.Mvc;
using Models.RequestResponse;
using Negocio;
using System.Net;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class MovimientoCajaController : ControllerBase
    {
        #region declaracion variables generales
        public readonly IMovimientoCajaNegocio _IMovimientoCajaNegocio = null;
        public readonly IMapper _mapper;
        #endregion

        #region constructor
        public MovimientoCajaController(IMapper mapper)
        {
            _mapper = mapper;
            _IMovimientoCajaNegocio = new MovimientoCajaNegocio(_mapper);
        }
        #endregion

        #region crud methods
        /// <summary>
        /// Retorna todos los registros
        /// </summary>
        /// <returns>Retorna todos los registros</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<MovimientoCajaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult GetAll()
        {
            List<MovimientoCajaResponse> lst = _IMovimientoCajaNegocio.GetAll();
            return Ok(lst);
        }

        /// <summary>
        /// retorna el registro por Primary key
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns>retorna el registro</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(MovimientoCajaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult GetById(int id)
        {
            MovimientoCajaResponse res = _IMovimientoCajaNegocio.GetById(id);
            return Ok(res);
        }

        /// <summary>
        /// Inserta un nuevo registro
        /// </summary>
        /// <param name="request">Registro a insertar</param>
        /// <returns>Retorna el registro insertado</returns>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(MovimientoCajaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] MovimientoCajaRequest request)
        {
            MovimientoCajaResponse res = _IMovimientoCajaNegocio.Create(request);
            return Ok(res);
        }

        /// <summary>
        /// Actualiza un registro
        /// </summary>
        /// <param name="entity">registro a actualizar</param>
        /// <returns>retorna el registro Actualiza</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(MovimientoCajaResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Update([FromBody] MovimientoCajaRequest entity)
        {
            MovimientoCajaResponse res = _IMovimientoCajaNegocio.Update(entity);
            return Ok(res);
        }

        /// <summary>
        /// Elimina un registro
        /// </summary>
        /// <param name="id">Valor del PK</param>
        /// <returns>Cantidad de registros afectados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(int))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Delete(int id)
        {
            int res = _IMovimientoCajaNegocio.Delete(id);
            return Ok(res);
        }
        #endregion
    }
}