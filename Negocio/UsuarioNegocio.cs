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

namespace Repositorio
{
    public class UsuarioNegocio : IUsuarioNegocio
    {
        #region declaracion variables generales
        public readonly IUsuarioRepositorio _IUsuarioRepositorio = null;
        public readonly IMapper _mapper;
        #endregion

        #region constructor
        public UsuarioNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IUsuarioRepositorio = new UsuarioRepositorio();
        }

       
        #endregion
 public UsuarioResponse BuscarPorNombreUsuario(string username)
        {
            UsuarioResponse usuario=_mapper.Map<UsuarioResponse>(_IUsuarioRepositorio.GetByUserName(username));
            return usuario;
        }
        #region Methodos_CRUD
        public UsuarioResponse Create(UsuarioRequest entity)
        {
            Usuario cat = _mapper.Map<Usuario>(entity);
            cat = _IUsuarioRepositorio.Create(cat);
            UsuarioResponse res = _mapper.Map<UsuarioResponse>(cat);
            return res;
        }

        public List<UsuarioResponse> CreateMultiple(List<UsuarioRequest> request)
        {
            List<Usuario> cat = _mapper.Map<List<Usuario>>(request);
            cat = _IUsuarioRepositorio.InsertMultiple(cat);
            List<UsuarioResponse> res = _mapper.Map<List<UsuarioResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IUsuarioRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<UsuarioRequest> request)
        {
            List<Usuario> cat = _mapper.Map<List<Usuario>>(request);
            int cantidad = _IUsuarioRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<UsuarioResponse> GetAll()
        {
            List<Usuario> lst = _IUsuarioRepositorio.GetAll();
            List<UsuarioResponse> res = _mapper.Map<List<UsuarioResponse>>(lst);
            return res;
        }

        public List<UsuarioResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public UsuarioResponse GetById(int id)
        {
            Usuario cat = _IUsuarioRepositorio.GetById(id);
            UsuarioResponse res = _mapper.Map<UsuarioResponse>(cat);
            return res;
        }

        public UsuarioResponse GetByUserName(string userName)
        {
            Usuario user = _IUsuarioRepositorio.GetByUserName(userName);
            UsuarioResponse res = _mapper.Map<UsuarioResponse>(user);
            return res;
        }

        public UsuarioResponse Update(UsuarioRequest entity)
        {
            Usuario cat = _mapper.Map<Usuario>(entity);
            cat = _IUsuarioRepositorio.Update(cat);
            UsuarioResponse res = _mapper.Map<UsuarioResponse>(cat);
            return res;
        }

        public List<UsuarioResponse> UpdateMultiple(List<UsuarioRequest> request)
        {
            List<Usuario> cat = _mapper.Map<List<Usuario>>(request);
            cat = _IUsuarioRepositorio.UpdateMultiple(cat);
            List<UsuarioResponse> res = _mapper.Map<List<UsuarioResponse>>(cat);
            return res;
        }
        #endregion
    }
}