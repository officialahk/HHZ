using MLMS.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MLMS.Services
{
    public class ContributionService
    {
        ApplicationDbContext Db = new ApplicationDbContext();


        public Contribution FindById(int? id)
        {
            return Db.Contributions.Find(id);
        }

        public IEnumerable<Contribution> Contributions()
        {
            return Db.Contributions.Include("ActivityType").ToList();
        }

        public IEnumerable<Contribution> FindByUserId(string userId)
        {
            return Db.Contributions.Where(x=>x.UserId==userId).ToList();
        }
        public void Create(Contribution contribution)
        {
            Db.Contributions.Add(contribution);
            Db.SaveChanges();
        }

        public void Update(Contribution contribution)
        {
            Db.Entry(contribution).State = EntityState.Modified;
            Db.SaveChanges();
        }


        public void Delete(Contribution contribution)
        {
            Db.Contributions.Remove(contribution);
            Db.SaveChanges();
        }




    }
}