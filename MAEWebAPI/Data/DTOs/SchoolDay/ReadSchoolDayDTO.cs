using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.DTOs.SchoolDay
{
    public class ReadSchoolDayDTO
    {
        [Required]
        public int SchoolDayID { get; set; }
        [Required]
        public DateTime Description { get; set; }
    }
}
