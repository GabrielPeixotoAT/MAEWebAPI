using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.Abstence
{
    public class ReadAbstenceDTO
    {
        [Required]
        public int AbstenceID { get; set; }
        public string? Description { get; set; }
        [Required]
        public int ClassSheduleIDFK { get; set; }
        [Required]
        public int SubjectIDFK { get; set; }
        [Required]
        public int ClassCount { get; set; }
    }
}
