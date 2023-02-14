using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.Subjects
{
    public class CreateSubjectDTO
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(6)]
        public string Code { get; set; }
        [Required]
        public int TotalClasses { get; set; }
    }
}
