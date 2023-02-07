using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Requests.Subjects
{
    public class ClassSheduleRequest
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
