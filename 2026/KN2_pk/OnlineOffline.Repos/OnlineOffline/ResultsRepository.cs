using Microsoft.EntityFrameworkCore;
using OnlineOffline.Core;
using OnlineOffline.Core.Models;

namespace OnlineOffline
{
    public class ResultsRepository
    {
        private readonly LearningContext _ctx;

        public ResultsRepository(LearningContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<LearningResult> GetAll()
        {
            return _ctx.Results.Include(x=> x.Mode).Include(x=> x.Subject).ToList();
        }
    }
}
