namespace UtilInterface
{
    public interface ICRUDRepositorio<T>:IDisposable where T : class
    {
        List<T> GetAll();
        T GetById(object id);
        T Create(T entity);
        T Update(T entity);
        int Delete(object id);
        int DeleteMultipleItems(List<T> lista);
        List<T> InsertMultiple(List<T> lista);
        List<T> UpdateMultiple(List<T> lista);
        List<T> GetAutoComplete(string query);
    }
}