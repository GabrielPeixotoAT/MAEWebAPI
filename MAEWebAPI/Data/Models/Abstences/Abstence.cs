using MAEWebAPI.Data.Models.Subjects;
using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Models.Abstences
{
    public class Abstence
    {
        [Key]
        [Required]
        public int AbstenceID { get; set; }
        public string? Description { get; set; }
        [Required]
        public int ClassSheduleIDFK { get; set; }
        [Required]
        public int SubjectIDFK { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual ClassSchedule ClassSchedule { get; set; }
    }
}
