using ServiceLayer;
using BusinessLayer;
namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunService runService = new RunService();
            AthleteService athleteService = new AthleteService();

            //athleteService.AddAthlete("Martin", "Kostadinov", new DateTime(2007, 3, 7), "male", "Team Klyavkov", "Sprinter");
            //Console.WriteLine("Athlete added successfully!");

            runService.AddRun(3, 100, 11.34, new DateTime(2025, 2, 14), true, null, null, null, null, "Personal Best");
            Console.WriteLine("Run added successfully!");

            //athleteService.UpdateAthlete(1, "Martin", "Kostadinov", new DateTime(2007, 3, 7), "male", "ASC Team Klyavkov", "Sprinter");
            //Console.WriteLine("Athlete modified successfully!");

            //runService.UpdateRun(1, 1, 100, 11.45, new DateTime(2024, 10, 14), true, null, null, null, null, "Personal Best");
            //Console.WriteLine("Run modified successfully!");

            //Run run = runService.GetPersonalBest(2, 100);
            //Athlete athlete = run.Athlete;
            //Console.WriteLine($"{athlete.FirstName} {athlete.LastName} - {athlete.Gender} - {run.Distance} PB - {run.TimeSeconds}");

            //athleteService.DeleteAthlete(2);
            //Console.WriteLine("Succsessfully deleted athlete!");

            //runService.DeleteRun(2);
            //Console.WriteLine("Succsessfully deleted run!");
            Run run = runService.GetRun(6);
            Console.WriteLine(run);
        }
    }
}
