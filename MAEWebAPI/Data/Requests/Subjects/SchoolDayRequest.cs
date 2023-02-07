using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Requests.Subjects
{
    public class SchoolDayRequest
    {
        [Required]
        public DateTime Description { get; set; }
    }
}
