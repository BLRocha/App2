using App2.Context;
using App2.Models.Repositores.Repository;
using Microsoft.EntityFrameworkCore;

namespace App2.Models.Repositores
{
    public class JobHistoryRepository : ARepository
    {
        public JobHistoryRepository(ContextDb context) : base(context)
        {
        }

        public async Task<IList<JobHistoryModel>> GetJobs()
        {
            var a = typeof(JobHistoryRepository);
            var b = a.GetProperties();
            return await _context.JobHistory.ToListAsync();
        }

    }
}
