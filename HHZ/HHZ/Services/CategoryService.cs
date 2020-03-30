using System.Collections.Generic;
using System.Linq;
using MLMS.Models;
using System.Data.Entity;

namespace MLMS.Services
{
    public class CategoryService
    {
        ApplicationDbContext _db = new ApplicationDbContext();


        public Category FindById(int? id)
        {
           return _db.Categories.Find(id);
        }

        public IEnumerable<Category> Categories()
        {
            return _db.Categories.ToList();
        }

        public void Create(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            _db.Entry(category).State = EntityState.Modified;
            _db.SaveChanges();
        }


        public void Delete(Category category)
        {
            _db.Categories.Remove(category);
            _db.SaveChanges();
        }
            

    }
}