using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Models.Abstences
{
    public class SubjectAbstences
    {
        [Key]
        [Required]
        public int SubjectAbstencesID { get; set; }
        [Required]
        public int SubjectIDFK { get; set; }
        [Required]
        public int AbstencesCount { get; set; }
    }
}
