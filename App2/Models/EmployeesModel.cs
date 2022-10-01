using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace App2.Models
{
    public class EmployeesModel
    {
        public int Id { get; set; }
        public String? Fisrt_name { get; set; }
        public String? Last_name { get; set; }
        public String? Email { get; set; }
        public String? Phone_number { get; set; }
        public DateTime? Hire_date { get; set; }
        public String? Job_id { get; set; }
        public String? Salary { get; set; }
        public String? Commision_pct { get; set; }
        public String? Manager_id { get; set; }
        public String? Department_id { get; set; }
    }
}
