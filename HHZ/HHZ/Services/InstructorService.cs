using MLMS.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MLMS.Services
{
    public class InstructorService
    {
        public ApplicationDbContext Db { get; } = new ApplicationDbContext();


        public Instructor FindById(int? id)
        {
            return Db.Instructors.Include("User").FirstOrDefault(x => x.InstructorId==id);
        }

        public Instructor FindByUserId(string userId)
        {
            return Db.Instructors.FirstOrDefault(x => x.UserId == userId);
        }
        public IEnumerable<Instructor> Instructors()
        {
            return Db.Instructors.Include("User").Include("Courses").ToList();
        }

        public void Create(Instructor instructor)
        {
            Db.Instructors.Add(instructor);
            Db.SaveChanges();
        }

        public void Payment(Transaction transaction)
        {
            Db.Transactions.Add(transaction);
            Db.SaveChanges();
        }

        public IEnumerable<Transaction> Transactions()
        {
            return Db.Transactions.Include("Instructor").ToList();

        }

        public IEnumerable<Transaction> TransactionsByInstructorId(int instructorId)
        {
            return Db.Transactions.Include("Instructor").Where(x => x.InstructorId == instructorId).ToList();

        }

        public void Update(Instructor instructor)
        {
            Db.Entry(instructor).State = EntityState.Modified;
            Db.SaveChanges();
        }


        public void Delete(Instructor instructor)
        {
            Db.Instructors.Remove(instructor);
            Db.SaveChanges();
        }


        public void SendMessage(ProfileMessage profileMessage)
        {
            Db.ProfileMessages.Add(profileMessage);
            Db.SaveChanges();
        }

    }
}