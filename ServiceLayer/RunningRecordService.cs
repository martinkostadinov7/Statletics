using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    internal class RunningRecordService
    {
        private RunningRecordRepository runningRecordRepository;
        private DisciplineRepository disciplineRepository;
        public RunningRecordService()
        {
            runningRecordRepository = new RunningRecordRepository(new StatleticsContext());
            disciplineRepository = new DisciplineRepository(new StatleticsContext());
        }

        public void CreateRunningRecord(int id_discipline, DateTime dateTime, TimeSpan result, bool hasSpikes, string activityType, bool isOutdoor)
        {
            Discipline discipline = disciplineRepository.Read(id_discipline);
            if (discipline == null) throw new ArgumentException($"Discipline with id {id_discipline} does not exist!");
            if (dateTime > DateTime.Now) throw new ArgumentException("Date cannot be in the future!");
            
            RunningRecord runningRecord = new RunningRecord();
            runningRecord.IdDiscipline = id_discipline;
            runningRecord.DateTime = dateTime;
            runningRecord.Result = result;
            runningRecord.HasSpikes = hasSpikes;
            runningRecord.ActivityType = activityType;
            runningRecord.IsOutdoor = isOutdoor;

            runningRecordRepository.Create(runningRecord);
        }
        public RunningRecord ReadRunningRecord(int id)
        {
            RunningRecord runningRecord = runningRecordRepository.Read(id);
            if (runningRecord == null) { throw new ArgumentException($"Record with id {id} does not exist!"); }
            return runningRecord;
        }
        public List<RunningRecord> ReadAllRunningRecords()
        {
            return runningRecordRepository.ReadAll();
        }
        public void UpdateRunningRecord(int id)
        {
            RunningRecord runningRecord = runningRecordRepository.Read(id);
            if (runningRecord == null) { throw new ArgumentException($"Record with id {id} does not exist!"); }
            runningRecordRepository.Update(runningRecord);
        }
        public void DeleteRunningRecord(int id)
        {
            RunningRecord runningRecord = runningRecordRepository.Read(id);
            if (runningRecord == null) { throw new ArgumentException($"Record with id {id} does not exist!"); }
            runningRecordRepository.Update(runningRecord);
        }
    }
}
