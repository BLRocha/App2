using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App2.Models.Mappers
{
    public class JobHistoryMapper : IEntityTypeConfiguration<JobHistoryModel>
    {
        public void Configure(EntityTypeBuilder<JobHistoryModel> builder)
        {
            builder.ToTable("JOB_HISTORY");
            builder.Property(x => x.Id).HasColumnName("EMPLOYEE_ID");
            builder.Property(x => x.StateDate).HasColumnName("START_DATE");
            builder.Property(x => x.EndDate).HasColumnName("END_DATE");
            builder.Property(x => x.JobEnd).HasColumnName("JOB_ID");
            builder.Property(x => x.DepartmentId).HasColumnName("DEPARTMENT_ID");
        }
    }
}
