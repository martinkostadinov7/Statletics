using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
namespace ServiceLayer
{
    public class CategoryService
    {
        private readonly CategoryRepository repository;

        public CategoryService()
        {
            repository = new CategoryRepository(new StatleticsContext());
        }
        public void CreateCategory(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Category name invalid!");
            }
            Category categoryFromDb = repository.ReadAll().FirstOrDefault(c => c.Name == name);
            if (categoryFromDb == null)
            {
                repository.Create(new Category
                {
                    Name = name,
                    Disciplines = new List<Discipline>()
                });
            }
            else
            {
                throw new ArgumentException($"Category with name {name} already exists!");
            }

            repository.Create(categoryFromDb);
            
        }
        public void DeleteCategory(int id)
        {
            Category categoryFromDb = repository.ReadAll().FirstOrDefault(c => c.Id == id);
            if (categoryFromDb == null) { throw new ArgumentException($"Category with id {id} does not exist!"); }
            repository.Delete(id);
        }
        public Category GetCategory(int id)
        {
            Category categoryFromDb = repository.Read(id); // to do navigationalproperties and readonly
            if (categoryFromDb == null) { throw new ArgumentException($"Category with id {id} does not exist!"); }
            return categoryFromDb;
        }
        public List<Category> GetAllCategories()
        {
            return repository.ReadAll().ToList(); // same
        }
        public void Update(int id)
        {
            Category categoryFromDb = GetCategory(id);
            if (categoryFromDb == null) { throw new ArgumentException($"Category with id {id} does not exist!"); }
            repository.Update(categoryFromDb); // same
        }
    }
}
