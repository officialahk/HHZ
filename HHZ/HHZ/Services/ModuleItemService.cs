using System.Collections.Generic;
using System.Linq;
using MLMS.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace MLMS.Services
{
    public class ModuleItemService
    {
        public ApplicationDbContext Db { get; } = new ApplicationDbContext();

        public ModuleItem FindById(int? id)
        {
           return Db.ModuleItems.Include("CourseModule").FirstOrDefault(x => x.ModuleItemId==id);
        }

        public IEnumerable<ModuleItem> ModulesItems()
        {
            return Db.ModuleItems.Include("CourseModule").ToList();
        }

        public void Create(ModuleItem item)
        {
            Db.ModuleItems.Add(item);
            Db.SaveChanges();
        }

        public void Update(ModuleItem item)
        {
            Db.Entry(item).State = EntityState.Modified;
            Db.SaveChanges();
        }


        public void Delete(ModuleItem item)
        {
            Db.ModuleItems.Remove(item);
            Db.SaveChanges();
        }

        
    }
}