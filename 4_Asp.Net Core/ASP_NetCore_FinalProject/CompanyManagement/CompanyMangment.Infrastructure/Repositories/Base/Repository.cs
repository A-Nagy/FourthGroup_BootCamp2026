
using CompanyMangment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyMangment.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T:class
    {
        protected readonly AppDbContext _dbContext;

        private readonly DbSet<T> _dbset;

        public Repository(AppDbContext db)
        {
           _dbContext = db;
            _dbset = db.Set<T>();
        }
       
        public void Add(T obj)
        {
            _dbset.Add(obj);
         }

        public void Delete(T obj)
        {
            _dbset.Remove(obj);

        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();//Include(e => e.Department)
        }

        public T GetById(int Id)
        {
            return _dbset.Find(Id);
        }

        public void Update(T obj)
        {
            _dbset.Update(obj);
     
        }
        private void Save() 
        {
            _dbContext.SaveChanges();
        }
    }
}

 