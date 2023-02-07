using MAEWebAPI.Data.Models.Abstences;
using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Models.Subjects
{
    public class ClassSchedule
    {
        [Key]
        [Required]
        public int ClassScheduleID { get; set; }
        [Required]
        public string Shedules { get; set; }
        public int? SubjectIDFK { get; set; }
        [Required]
        public int SchoolDayIDFK { get; set; }  

        public virtual SchoolDay SchoolDay { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual List<Abstence> Abstences { get; set; }
    }
}
