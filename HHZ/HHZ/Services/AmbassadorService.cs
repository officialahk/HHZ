using MLMS.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MLMS.Services
{
    public class AmbassadorService
    {
        private  ApplicationDbContext Db { get; } = new ApplicationDbContext();


        public Ambassador FindById(int? id)
        {
            return Db.Ambassadors.Include("User").FirstOrDefault(x => x.AmbassadorId == id);
        }

        public Ambassador FindByUserId(string userId)
        {
            return Db.Ambassadors.FirstOrDefault(x => x.UserId == userId);
        }
        public IEnumerable<Ambassador> GetAll()
        {
            return Db.Ambassadors.Include("User").ToList();
        }

        public void Create(Ambassador ambassador)
        {
            Db.Ambassadors.Add(ambassador);
            Db.SaveChanges();
        }

        public void Update(Ambassador ambassador)
        {
            Db.Entry(ambassador).State = EntityState.Modified;
            Db.SaveChanges();
        }


        public void Delete(Ambassador ambassador)
        {
            Db.Ambassadors.Remove(ambassador);
            Db.SaveChanges();
        }
    }
}