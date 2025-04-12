using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
namespace DataLayer
{
    public class AthleteContext : IDb<Athlete, int>
    {
        private StatleticsContext dbContext;

        public AthleteContext()
        {
            this.dbContext = new StatleticsContext();
        }

        public void Add(Athlete item)
        {
            dbContext.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Athlete athlete = GetById(id);
            dbContext.Athletes.Remove(athlete);
            dbContext.SaveChanges();
        }

        public List<Athlete> GetAll()
        {
            return dbContext.Athletes.ToList();
        }

        public Athlete? GetById(int id)
        {
            Athlete athleteFromDb = dbContext.Athletes.FirstOrDefault(a => a.Id == id);
            return athleteFromDb;
        }

        public void Update(Athlete item)
        {
            dbContext.Update(item);
            dbContext.SaveChanges();
        }
    }
}
