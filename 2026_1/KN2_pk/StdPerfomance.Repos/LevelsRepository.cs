using Microsoft.EntityFrameworkCore;
using StdPerfomance.Core;
using StdPerfomance.Core.Entities;

namespace StdPerfomance.Repos
{
    public class LevelsRepository
    {
        private readonly DataContext _ctx;
        public LevelsRepository(DataContext ctx)
        {
            _ctx = ctx;
        }

        public List<StressLevel> GetAll()
        {
            return _ctx.StressLevels.ToList();
        }

    }
}
