using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.SubjectAbstences
{
    public class ReadSubjectAbstencesDTO
    {
        [Required]
        public int SubjectAbstencesID { get; set; }
        [Required]
        public int SubjectIDFK { get; set; }
        [Required]
        public int AbstencesCount { get; set; }
    }
}
