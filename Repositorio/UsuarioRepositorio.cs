using DBModel.DBBodega;
using IRepositorio;
using Microsoft.EntityFrameworkCore;
using Repository.Generic;
using System.Data.Entity;

namespace Repositorio
{
    public class UsuarioRepositorio : GenericRepository<Usuario>, IUsuarioRepositorio
    {

        public List<Usuario> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public Usuario GetByUserName(string userName)
        {
            Usuario user = dbSet.Where(x => x.Username == userName).FirstOrDefault();
            return user;

        }

        public Usuario ObtenerPorUserName(string username)
        {
           Usuario usuario=dbSet.Where(x=>x.Username.ToLower() == username.ToLower()).FirstOrDefault();
            return usuario;
        }
    }
}