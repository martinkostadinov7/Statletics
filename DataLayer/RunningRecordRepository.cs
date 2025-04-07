using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RunningRecordRepository : IDb<RunningRecord, int>
    {
        private StatleticsContext dbContext;
        public RunningRecordRepository(StatleticsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(RunningRecord item)
        {
            Discipline disciplineFromDb = dbContext.Disciplines.Find(item.IdDiscipline);
            if (disciplineFromDb != null) item.IdDiscipline = disciplineFromDb.Id;

            dbContext.RunningRecords.Add(item);
            dbContext.SaveChanges();
        }

        public void Delete(int key)
        {
            RunningRecord runningRecordFromDb = Read(key);
            dbContext.RunningRecords.Remove(runningRecordFromDb);
            dbContext.SaveChanges();
        }

        public RunningRecord Read(int key, bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<RunningRecord> query = dbContext.RunningRecords;
            if (useNavigationalProperties) query = query
            .Include(b => b.IdDiscipline);

            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();

            RunningRecord runningRecord = query.FirstOrDefault(b => b.Id == key);

            if (runningRecord == null) throw new ArgumentException($"Running Record with id {key} does not exist!");

            return runningRecord;
        }

        public List<RunningRecord> ReadAll(bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<RunningRecord> query = dbContext.RunningRecords;
            if (useNavigationalProperties) query = query
            .Include(b => b.IdDiscipline);
            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();
            return query.ToList();
        }

        public void Update(RunningRecord item, bool useNavigationalProperties = false)
        {
            RunningRecord runningRecordFromDb = Read(item.Id, useNavigationalProperties);

            dbContext.Entry<RunningRecord>(runningRecordFromDb).CurrentValues.SetValues(item);

            if (useNavigationalProperties)
            {
                Discipline disciplineFromDb = dbContext.Disciplines.Find(item.IdDiscipline);
                if (disciplineFromDb != null) runningRecordFromDb.IdDiscipline = disciplineFromDb.Id;
                else runningRecordFromDb.IdDiscipline = item.IdDiscipline;

            }

            dbContext.SaveChanges();
        }
    }
}
