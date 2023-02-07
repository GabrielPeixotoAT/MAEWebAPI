using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.SchoolDay
{
    public class CreateSchoolDayDTO
    {
        [Required]
        public string Description { get; set; }
    }
}
