using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Requests.Subjects
{
    public class SubjectRequest
    {
        [Required(ErrorMessage = "The Subject Name is Required")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Subject Total Classes is Required")]
        public int TotalClasses { get; set; }
    }
}
