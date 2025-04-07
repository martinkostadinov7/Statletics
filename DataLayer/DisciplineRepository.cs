using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class DisciplineRepository : IDb<Discipline, int>
    {
        private StatleticsContext dbContext;

        public DisciplineRepository(StatleticsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Discipline item)
        {
            Category categoryFromDb = dbContext.Categories.Find(item.IdCategory);
            if (categoryFromDb != null) item.IdCategory = categoryFromDb.Id;

            dbContext.Disciplines.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(int key)
        {
            Discipline disciplineFromDb = Read(key);
            dbContext.Disciplines.Remove(disciplineFromDb);
            dbContext.SaveChanges();
        }

        public Discipline Read(int key, bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<Discipline> query = dbContext.Disciplines;
            if (useNavigationalProperties) query = query
            .Include(b => b.IdCategory);

            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();

            Discipline discipline = query.FirstOrDefault(d => d.Id == key);

            if (discipline == null) throw new ArgumentException($"Discipline with Id {key} does not exist!");
            return discipline;
        }

        public List<Discipline> ReadAll(bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<Discipline> query = dbContext.Disciplines;
            if (useNavigationalProperties) query = query
            .Include(b => b.IdCategory);

            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();

            return query.ToList();
        }

        public void Update(Discipline item, bool useNavigationalProperties = false)
        {
            Discipline disciplineFromDb = Read(item.Id, useNavigationalProperties);

            dbContext.Entry<Discipline>(disciplineFromDb).CurrentValues.SetValues(item);

            if (useNavigationalProperties)
            {
                Category categoryFromDb = dbContext.Categories.Find(item.IdCategory);
                if (categoryFromDb != null) disciplineFromDb.IdCategory = categoryFromDb.Id;
                else disciplineFromDb.IdCategory = item.IdCategory;
            }

            dbContext.SaveChanges();
        }
    }
}
