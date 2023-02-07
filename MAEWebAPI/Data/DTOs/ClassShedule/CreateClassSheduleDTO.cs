using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.ClassShedule
{
    public class CreateClassSheduleDTO
    {
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public int? SubjectIDFK { get; set; }
        [Required]
        public int SchoolDayIDFK { get; set; }
    }
}
