using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Requests.Subjects
{
    public class SchoolDayRequest
    {
        [Required]
        public string Description { get; set; }
    }
}
