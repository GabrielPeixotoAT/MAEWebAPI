using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.Abstence
{
    public class CreateAbstenceDTO
    {
        public string? Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int ClassSheduleIDFK { get; set; }
        [Required]
        public int SubjectIDFK { get; set; }
        [Required]
        public int ClassCount { get; set; }
    }
}
