using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Models.Subjects
{
    public class ClassSchedule
    {
        [Key]
        [Required]
        public int ClassScheduleID { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public int? SubjectIDFK { get; set; }
        [Required]
        public int SchoolDayIDFK { get; set; }
    }
}
