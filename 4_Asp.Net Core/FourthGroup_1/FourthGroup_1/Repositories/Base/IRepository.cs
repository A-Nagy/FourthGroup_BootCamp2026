namespace FourthGroup_1.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        T GetById(int Id);
        IEnumerable<T> GetAll();

        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);

      

    }
}
