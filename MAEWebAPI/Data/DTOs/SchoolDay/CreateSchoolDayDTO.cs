using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.SchoolDay
{
    public class CreateSchoolDayDTO
    {
        [Required]
        public DateTime Description { get; set; }
    }
}
