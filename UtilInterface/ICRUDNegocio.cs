using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilInterface
{
    public interface ICRUDNegocio<Request,Response>:IDisposable
    {
        /// <summary>
        /// Listar todo
        /// </summary>
        /// <returns>lista de una clase desde la Base de Datos</returns>
        List<Response> GetAll();
        /// <summary>
        ///Retorna registro en base a Primray Key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Response GetById(int id);
        /// <summary>
        /// Inserta un nuevo registro 
        /// </summary>
        /// <param name="entity">clase a insertar</param>
        /// <returns></returns>      
        Response  Create(Request entity);
        /// <summary>
        /// Actualiza un nuevo registro 
        /// </summary>
        /// <param name="entity">clase a actualizar</param>
        /// <returns></returns>
        Response Update(Request entity);
        /// <summary>
        /// eliminar registro en base al PK
        /// </summary>
        /// <param name="id">valor del PK<</param>
        /// <returns>retorna la cantidad de registros afectados</returns>
        int Delete(object id);
        /// <summary>
        /// Elimina multiples registros
        /// </summary>
        /// <param name="request">Lista de registros a eliminar<</param>
        /// <returns></returns>
        int DeleteMultipleItems(List<Request> lista);
        /// <summary>
        /// Insercion de multiples registros
        /// </summary>
        /// <param name="request">>Lista de registros a insertar</param>
        /// <returns>Los registros insertados</returns>
        List<Response> CreateMultiple(List<Request> lista);
        /// <summary>
        /// Actualizar multiples registros
        /// </summary>
        /// <param name="request">>Lista de registros a insertar</param>
        /// <returns>Los registros insertados</returns>
        List<Response> UpdateMultiple(List<Request> lista);
        /// <summary>
        /// Obtener lista de registros por coincidencia
        /// </summary>
        /// <param name="query">texto a buscar</param>
        /// <returns>lista de registros</returns>
        List<Response> GetAutoComplete(string query);
    }
}
