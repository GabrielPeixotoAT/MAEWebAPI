using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Models.Subjects
{
    public class Subject
    {
        [Key]
        [Required]
        public int SubjectID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int TotalClasses { get; set; }

        public virtual List<ClassSchedule> ClassSchedules { get; set; }
    }
}
