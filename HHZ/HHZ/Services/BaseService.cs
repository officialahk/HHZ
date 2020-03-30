using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MLMS.Models;

namespace MLMS.Services
{
    public class BaseService<T> where T:class
    {

        private ApplicationDbContext Db { get; } = new ApplicationDbContext();

        private readonly DbSet<T> _dbSet;
        public BaseService()
        {
            _dbSet = Db.Set<T>();
        }


        public T FindById(int? id)
        {
            return _dbSet.Find(id);
        }

        //public T FindByUserId(string userId)
        //{
        //    return _dbSet.FirstOrDefault(x => x.UserId == userId);
        //}
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Create(T model)
        {
            _dbSet.Add(model);
            Db.SaveChanges();
        }

        public void Update(T model)
        {
            Db.Entry(model).State = EntityState.Modified;
            Db.SaveChanges();
        }


        public void Delete(T model)
        {
            _dbSet.Remove(model);
            Db.SaveChanges();
        }
    }
}