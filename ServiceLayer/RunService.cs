using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
namespace ServiceLayer
{
    public class RunService
    {
        private RunContext context;
        private AthleteContext athleteContext;
        public RunService()
        {
            this.context = new RunContext();
            this.athleteContext = new AthleteContext();
        }
        public void AddRun(int athleteId, int distance, double timeSeconds,
                   DateTime date, bool isHandTimed = true, int? repetition = null,
                   int? totalRepetitions = null, TimeSpan? restBetween = null,
                   string shoes = null, string notes = null)
        {
            Athlete athlete = athleteContext.GetById(athleteId);
            if (athlete == null) throw new ArgumentException("Athlete does not exist!");
            if (distance < 0) throw new ArgumentException("Distance cannot be negative!");
            if (timeSeconds < 0) throw new ArgumentException("Time cannot be negative!");
            if (date > DateTime.Now) throw new ArgumentException("Date cannot be in the future!");
            if (repetition < 0) throw new ArgumentException("Repetition cannot be negative!");
            if (totalRepetitions < 0) throw new ArgumentException("Total repetitions cannot be negative!");

            var run = new Run
            {
                AthleteId = athleteId,
                Distance = distance,
                TimeSeconds = timeSeconds,
                Date = date,
                IsHandTimed = isHandTimed,
                Repetition = repetition,
                TotalRepetitions = totalRepetitions,
                Shoes = shoes,
                Notes = notes,
                RestBetween = restBetween
            };

            context.Add(run);
        }
        public void UpdateRun(int id, int athleteId, int distance, double timeSeconds,
                   DateTime date, bool isHandTimed = true, int? repetition = null,
                   int? totalRepetitions = null, TimeSpan? restBetween = null,
                   string shoes = null, string notes = null)
        {
            Run run = context.GetById(id);
            if (run == null) throw new ArgumentException("Run does not exist!");

            Athlete athlete = athleteContext.GetById(athleteId);
            if (athlete == null) throw new ArgumentException("Athlete does not exist!");
            if (distance < 0) throw new ArgumentException("Distance cannot be negative!");
            if (timeSeconds < 0) throw new ArgumentException("Time cannot be negative!");
            if (date > DateTime.Now) throw new ArgumentException("Date cannot be in the future!");
            if (repetition < 0) throw new ArgumentException("Repetition cannot be negative!");
            if (totalRepetitions < 0) throw new ArgumentException("Total repetitions cannot be negative!");


            run.AthleteId = athleteId;
            run.Distance = distance;
            run.TimeSeconds = timeSeconds;
            run.Date = date;
            run.IsHandTimed = isHandTimed;
            run.Repetition = repetition;
            run.TotalRepetitions = totalRepetitions;
            run.RestBetween = restBetween;
            run.Shoes = shoes;
            run.Notes = notes;

            context.Add(run);
        }
        public void DeleteRun(int id)
        {
            Run run = context.GetById(id);
            if (run == null) throw new ArgumentException("Run doesnt exist!");
            context.Delete(id);
        }
        public Run GetRun(int id)
        {
            Run run = context.GetById(id);
            if (run == null) throw new ArgumentException("Run doesnt exist!");
            return run;
        }
        public List<Run> GetRuns()
        {
            List<Run> runs = new List<Run>();
            foreach (var run in context.GetAll())
            {
                runs.Add(run);
            }
            return runs;
        }
    }
}
