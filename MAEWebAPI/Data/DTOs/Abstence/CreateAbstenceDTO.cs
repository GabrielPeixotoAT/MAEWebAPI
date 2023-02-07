using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.Abstence
{
    public class CreateAbstenceDTO
    {
        public string? Description { get; set; }
        [Required]
        public int ClassSheduleIDFK { get; set; }
        [Required]
        public int SubjectIDFK { get; set; }
    }
}
