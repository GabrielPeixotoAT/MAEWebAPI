using MAEWebAPI.Data.DTOs.SchoolDay;
using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Data.Result;

namespace MAEWebAPI.Services.Subjects.Interface
{
    public interface ISchoolDayService
    {
        Result<CreateSchoolDayDTO> InsertSchoolDay(SchoolDayRequest request);
        Result InsertMultiSchoolDays(List<SchoolDayRequest> request);
        IEnumerable<ReadSchoolDayDTO> GetSchoolDays();
        ReadSchoolDayDTO GetSchoolDayByDate(DateTime date);
        ReadSchoolDayDTO GetSchoolDayByID(int id);
    }
}
