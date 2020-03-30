using System.Collections.Generic;
using System.Linq;
using MLMS.Models;
using System.Data.Entity;

namespace MLMS.Services
{
    public class CoursePointerService
    {
        ApplicationDbContext _db = new ApplicationDbContext();


        public CoursePointer FindById(int? id)
        {
           return _db.CoursePointers.Include("Course").Where(x=>x.CoursePointerId==id).FirstOrDefault();
        }

        public IEnumerable<CoursePointer> CoursePointers()
        {
            return _db.CoursePointers.Include("Course").ToList();
        }
        public IEnumerable<CoursePointer> CoursePointers(int courseId)
        {
            return _db.CoursePointers.Include("Course").Where(x=>x.CourseId==courseId).ToList();
        }

        public void Create(CoursePointer pointer)
        {
            _db.CoursePointers.Add(pointer);
            _db.SaveChanges();
        }

        public void Update(CoursePointer pointer)
        {
            _db.Entry(pointer).State = EntityState.Modified;
            _db.SaveChanges();
        }


        public void Delete(CoursePointer pointer)
        {
            _db.CoursePointers.Remove(pointer);
            _db.SaveChanges();
        }
            

    }
}