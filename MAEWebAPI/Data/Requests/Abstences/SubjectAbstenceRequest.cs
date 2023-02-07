using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Requests.Abstences
{
    public class SubjectAbstenceRequest
    {
        [Required]
        public string SubjectName { get; set; }
        [Required]
        public int AbstencesCount { get; set; }
        [Required]
        public int TotalClasses { get; set; }
        [Required]
        public Decimal PresencePercent { get; set; }
    }
}
