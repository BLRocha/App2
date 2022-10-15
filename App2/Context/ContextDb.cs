using App2.Models;
using App2.Models.Mappers;
using Microsoft.EntityFrameworkCore;

namespace App2.Context
{
    public class ContextDb : DbContext
    {
        public DbSet<EmployeesModel>? Employees { get; set; }
        public DbSet<JobHistoryModel>? JobHistory { get; set; }
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeesMapper());
            modelBuilder.ApplyConfiguration(new JobHistoryMapper());
        }
    }
}
