using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class RunContext : IDb<Run, int>
    {
        private StatleticsContext dbContext;

        public RunContext()
        {
            this.dbContext = new StatleticsContext();
        }
        public void Add(Run item)
        {
            dbContext.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Run runFromDb = GetById(id);
            dbContext.Runs.Remove(runFromDb);
            dbContext.SaveChanges();
        }

        public List<Run> GetAll()
        {
            return dbContext.Runs.ToList();
        }

        public Run GetById(int id)
        {
            Run runFromDb = dbContext.Runs.FirstOrDefault(a => a.Id == id);
            if (runFromDb == null) throw new ArgumentException($"Athlete with id {id} does not exist.");
            return runFromDb;
        }

        public void Update(Run item)
        {
            dbContext.Update(item);
            dbContext.SaveChanges();
        }
    }
}
