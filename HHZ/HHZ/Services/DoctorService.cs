using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HHZ.Data;

namespace HHZ.Services
{
    public class DoctorService
    {
        public ApplicationDbContext Db { get; } = new ApplicationDbContext();


        public Doctor FindById(int? id)
        {
            return Db.Doctors.Find(id);
        }


        public Doctor FindByUserId(string userId)
        {
            var doc = Db.Doctors.FirstOrDefault(D => D.UserId == userId);
            return doc;
        }

        public IEnumerable<Doctor> Doctors()
        {
            return Db.Doctors.ToList();
        }

        public void Create(Doctor doctor)
        {
            Db.Doctors.Add(doctor);
            Db.SaveChanges();
        }


        public async Task CreateAsync(Doctor doctor)
        {
            Db.Doctors.Add(doctor);
           await Db.SaveChangesAsync();
        }

        public void Update(Doctor doctor)
        {
            Db.Entry(doctor).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Update(Doctor doctor, string userId)
        {
            doctor.UserId = userId;
            Db.Entry(doctor).State = EntityState.Modified;
            Db.SaveChanges();
        }


        public void Delete(Doctor doctor)
        {
            Db.Doctors.Remove(doctor);
            Db.SaveChanges();
        }
    }
}