using App2.Context;
using App2.Models.Repositores.Repository;
using Microsoft.EntityFrameworkCore;

namespace App2.Models.Repositores
{
    public class JobHistoryRepositore : ARepository
    {
        public JobHistoryRepositore(ContextDb context) : base(context)
        {
        }

        public async Task<IList<JobHistoryModel>> GetJobs()
        {
            var a = typeof(JobHistoryRepositore);
            var b = a.GetProperties();
            return await _context.JobHistory.ToListAsync();
        }

    }
}
