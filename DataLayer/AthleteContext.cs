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
            Athlete athleteFromDb = GetById(id);
            dbContext.Athletes.Remove(athleteFromDb);
            dbContext.SaveChanges();
        }

        public List<Athlete> GetAll()
        {
            return dbContext.Athletes.ToList();
        }

        public Athlete GetById(int id)
        {
            Athlete athleteFromDb = dbContext.Athletes.FirstOrDefault(a => a.Id == id);
            if (athleteFromDb == null) throw new ArgumentException($"Athlete with id {id} does not exist.");
            return athleteFromDb;
        }

        public void Update(Athlete item)
        {
            dbContext.Update(item);
            dbContext.SaveChanges();
        }
    }
}
