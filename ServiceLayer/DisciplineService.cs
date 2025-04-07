using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    internal class DisciplineService
    {
        private DisciplineRepository disciplineRepository;
        private CategoryRepository categoryRepository;

        public DisciplineService()
        {
            this.disciplineRepository = new DisciplineRepository(new StatleticsContext());
            this.categoryRepository = new CategoryRepository(new StatleticsContext());
        }
        public void CreateDiscipline(int id_category, string name)
        {
            Category categoryFromDb = categoryRepository.Read(id_category);
           
            if (categoryFromDb == null) { throw new ArgumentException($"Category with id {id_category} does not exist!"); }
            if (name.Length <= 0) { throw new ArgumentException("Invalid discipline name!"); }
           
            Discipline discipline = new Discipline();
            discipline.IdCategory = id_category;
            discipline.Name = name;
            disciplineRepository.Create(discipline);
        }
        public Discipline ReadDiscipline(int key)
        {
            Discipline discipline = disciplineRepository.Read(key);
            if (discipline == null) { throw new ArgumentException($"Discipline with id {key} does not exist!"); }
            return discipline;
        }
        public List<Discipline> ReadAllDisciplines()
        {
            return disciplineRepository.ReadAll();
        }
        public void UpdateDiscipline(int key)
        {
            Discipline discipline = disciplineRepository.Read(key);
            if (discipline == null) { throw new ArgumentException($"Discipline with id {key} does not exist!"); }
            disciplineRepository.Update(discipline);
        }
        public void DeleteDiscipline(int key)
        {
            Discipline discipline = disciplineRepository.Read(key);
            if (discipline == null) { throw new ArgumentException($"Discipline with id {key} does not exist!"); }
            disciplineRepository.Delete(discipline);
        }

    }
}
