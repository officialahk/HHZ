using System.Collections.Generic;
using System.Linq;
using MLMS.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace MLMS.Services
{
    public class CourseModuleService
    {
        private ApplicationDbContext Db { get; } = new ApplicationDbContext();


        public CourseModule FindById(int? id)
        {
           return Db.CourseModules.Include("Course").FirstOrDefault(x => x.CourseModuleId==id);
        }

        public IEnumerable<CourseModule> CourseModules()
        {
            return Db.CourseModules.Include("Course").ToList();
        }

        public IEnumerable<CourseModule> CourseModules(int courseId)
        {
            return Db.CourseModules.Include("Course").Where(x=>x.CourseId==courseId).ToList();
        }

        public IEnumerable<SelectListItem> ModuleDropDown(int courseId)
        {
            return Db.CourseModules.Where(x => x.CourseId == courseId).Select(x => new SelectListItem { Value = x.CourseModuleId.ToString(), Text = x.Title });
        }
        public void Create(CourseModule module)
        {
            Db.CourseModules.Add(module);
            Db.SaveChanges();
        }

        public void Update(CourseModule module)
        {
            Db.Entry(module).State = EntityState.Modified;
            Db.SaveChanges();
        }


        public void Delete(CourseModule module)
        {
            Db.CourseModules.Remove(module);
            Db.SaveChanges();
        }
            

    }
}