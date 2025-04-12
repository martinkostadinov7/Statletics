using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
namespace ServiceLayer
{
    public class AthleteService
    {
        private AthleteContext context;

        public AthleteService()
        {
            this.context = new AthleteContext();
        }

        public void AddAthlete(string firstName, string lastName, DateTime? dateOfBirth, string gender, string? club, string? notes)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name is required!");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name is required!");
            if (string.IsNullOrWhiteSpace(gender))
                throw new ArgumentException("Gender is required!");
            if (dateOfBirth < DateTime.Now)
                throw new ArgumentException("Birth date cannot be in the future!");
            if (gender != "male" || gender != "female")
                throw new ArgumentException("Invalid gender!");

            var athlete = new Athlete
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                Club = club,
                Notes = notes
            };
      
            context.Add(athlete);
        }
        
        public void DeleteAthlete(int id)
        {
            Athlete athleteFromDb = context.GetById(id);
            if (athleteFromDb == null) throw new ArgumentException($"Athlete with id {id} does not exist!");
            context.Delete(id);
        }

        public void UpdateAthlete(int id, string firstName, string lastName, DateTime? dateOfBirth, string gender, string? club, string? notes)
        {
            Athlete athlete = context.GetById(id);
            if (athlete == null) throw new ArgumentException("Athlete does not exist!");

            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name is required!");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name is required!");
            if (string.IsNullOrWhiteSpace(gender))
                throw new ArgumentException("Gender is required!");
            if (dateOfBirth < DateTime.Now)
                throw new ArgumentException("Birth date cannot be in the future!");
            if (gender != "male" || gender != "female")
                throw new ArgumentException("Invalid gender!");

            athlete.FirstName = firstName;
            athlete.LastName = lastName;
            athlete.DateOfBirth = dateOfBirth;
            athlete.Gender = gender;
            athlete.Club = club;
            athlete.Notes = notes;

            context.Update(athlete);
        }

        public Athlete GetAthlete(int id)
        {
            Athlete athlete = context.GetById(id);
            if (athlete == null) throw new ArgumentException("Athlete does not exist!");
            return athlete;
        }

        public List<Athlete> GetAthletes()
        {
            List<Athlete> athletes = new List<Athlete>();
            foreach (var athlete in context.GetAll())
            {
                athletes.Add(athlete);
            }
            return athletes;
        }
    }
}
