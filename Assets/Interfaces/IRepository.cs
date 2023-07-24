namespace Interfaces
{
    public interface IRepository<T>
    {
        public void Add (T entity);
        public void UpdateData (T entity);
        public void Delete (int id);
        T Get (int id);
    }
}