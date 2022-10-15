using System.ComponentModel.DataAnnotations.Schema;

namespace App2.Models
{
    public class JobHistoryModel
    {
        public int Id { get; set; }
        public DateTime? StateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? JobEnd { get; set; }
        public int? DepartmentId { get; set; }
    }
}
