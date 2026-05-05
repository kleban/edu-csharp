using Microsoft.EntityFrameworkCore;
using StdPerfomance.Core;
using StdPerfomance.Core.Entities;

namespace StdPerfomance.Repos
{
    public class ScoresRepository
    {
        private readonly DataContext _ctx;
        public ScoresRepository(DataContext ctx)
        {
            _ctx = ctx;
        }

        public List<StudentScore> GetAll()
        {
            return _ctx.StudentScores.Include(x=> x.StressLevel).ToList();
        }

        public void Add(StudentScore studentScore) 
        { 
            _ctx.Add(studentScore);
            _ctx.SaveChanges();
        }
    }
}
