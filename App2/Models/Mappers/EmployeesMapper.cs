using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App2.Models.Mappers
{
    public class EmployeesMapper : IEntityTypeConfiguration<EmployeesModel>
    {
        public void Configure(EntityTypeBuilder<EmployeesModel> builder)
        {
            builder.ToTable("EMPLOYEES");
            builder.Property(x => x.Id).HasColumnName("EMPLOYEE_ID");
            builder.Property(x => x.Fisrt_name).HasColumnName("FIRST_NAME");
            builder.Property(x => x.Last_name).HasColumnName("LAST_NAME");
            builder.Property(x => x.Email).HasColumnName("EMAIL");
            builder.Property(x => x.Phone_number).HasColumnName("PHONE_NUMBER");
            builder.Property(x => x.Hire_date).HasColumnName("HIRE_DATE");
            builder.Property(x => x.Job_id).HasColumnName("JOB_ID");
            builder.Property(x => x.Salary).HasColumnName("SALARY");
            builder.Property(x => x.Commision_pct).HasColumnName("COMMISSION_PCT");
            builder.Property(x => x.Manager_id).HasColumnName("MANAGER_ID");
            builder.Property(x => x.Department_id).HasColumnName("DEPARTMENT_ID");
        }
    }
}
