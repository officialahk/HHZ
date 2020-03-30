using MLMS.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MLMS.Services
{
    public class BatchService
    {
        ApplicationDbContext _db = new ApplicationDbContext();


        public Batch FindById(int? id)
        {
            return _db.Batches.Find(id);
        }

        public IEnumerable<Batch> Batches()
        {
            return _db.Batches.Include("Course").Include("Instructor").ToList();
        }

        public void Create(Batch batch)
        {
            _db.Batches.Add(batch);
            _db.SaveChanges();
        }

        public void Update(Batch batch)
        {
            _db.Entry(batch).State = EntityState.Modified;
            _db.SaveChanges();
        }


        public void Delete(Batch batch)
        {
            _db.Batches.Remove(batch);
            _db.SaveChanges();
        }


        public void Enrollment(BatchEnrollment enrollment)
        {
            _db.BatchEnrollments.Add(enrollment);
            _db.SaveChanges();
        }

        public IEnumerable<BatchEnrollment> GetEnrollments()
        {
            return _db.BatchEnrollments.Include("Student").Include("Course").Include("Batch").ToList();
        }
    }
}