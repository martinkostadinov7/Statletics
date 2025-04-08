
using BusinessLayer;
using ServiceLayer;
using System.Globalization;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunningRecordService service = new RunningRecordService();
            service.CreateRunningRecord(1, DateTime.Now, TimeSpan.FromMilliseconds(12345), true, "competiton", true);
            DisciplineService disciplineService = new DisciplineService();
            Discipline discipline = disciplineService.ReadDiscipline(1); 
            RunningRecord runningRecord = service.GetPersonalBest(1);
            Console.WriteLine($"{discipline.Name} - {runningRecord.Result.Seconds}.{runningRecord.Result.Milliseconds} - {runningRecord.DateTime}");

        }
    }
}
