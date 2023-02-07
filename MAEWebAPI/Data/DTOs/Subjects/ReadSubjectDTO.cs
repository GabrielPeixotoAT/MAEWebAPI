using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.Subjects
{
    public class ReadSubjectDTO
    {
        [Required]
        public int SubjectID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public int TotalClasses { get; set; }
    }
}
