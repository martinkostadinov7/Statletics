using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class CategoryRepository : IDb<Category, int>
    {
        private StatleticsContext dbContext;
        public CategoryRepository(StatleticsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Category item)
        {
            List<Discipline> disciplines = new List<Discipline>(item.Disciplines.Count);
            for (int i = 0; i < item.Disciplines.Count; ++i)
            {
                Discipline disciplineFromDb = dbContext.Disciplines.Find(item.Disciplines[i].ISBN);
                if (disciplineFromDb != null) disciplines.Add(disciplineFromDb);
                else disciplines.Add(item.Disciplines[i]);
            }
            item.Disciplines = disciplines;

            dbContext.Categories.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(int key)
        {
            Category categoryFromDb = dbContext.Categories.Find(key);
            if (categoryFromDb == null) { throw new ArgumentException($"Category with key {key} does not exist!"); }
            dbContext.Categories.Remove(categoryFromDb);
            dbContext.SaveChanges();
        }

        public Category Read(int key, bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<Category> query = dbContext.Categories;
            if (useNavigationalProperties) query = query.Include(o => o.Disciplines);
            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();

            Category category = query.FirstOrDefault(o => o.Id == key);

            if (category == null) throw new ArgumentException($"Order with id = {key} does not exist!");

            return category;
        }

        public List<Category> ReadAll(bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<Category> query = dbContext.Categories;
            if (useNavigationalProperties) query = query.Include(o => o.Disciplines);
            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();
            return query.ToList();
        }

        public void Update(Category item, bool useNavigationalProperties = false)
        {
            Category categoryFromDb = Read(item.Id, useNavigationalProperties);

            dbContext.Entry<Category>(categoryFromDb).CurrentValues.SetValues(item);

            if (useNavigationalProperties)
            { 
                List<Discipline> disciplines = new List<Discipline>(item.Disciplines.Count);
                for (int i = 0; i < item.Disciplines.Count; ++i)
                {
                    Discipline genreFromDb = dbContext.Disciplines.Find(item.Disciplines[i].Id);
                    if (genreFromDb != null) disciplines.Add(genreFromDb);
                    else disciplines.Add(item.Disciplines[i]);
                }
                categoryFromDb.Disciplines = disciplines;
            }

            dbContext.SaveChanges();
        }
    }
}
