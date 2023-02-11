using System.ComponentModel.DataAnnotations;

namespace MAEWebAPI.Data.Requests.Subjects
{
    public class ClassSheduleResponse
    {
        public string Shedules { get; set; }
        public int SchoolDayIDFK { get; set; }
        public string SubjectCode { get; set; }
    }
}
