using MAEWebAPI.Data.DTOs.ClassShedule;
using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Data.Result;

namespace MAEWebAPI.Services.Subjects.Interface
{
    public interface IClassSheduleService
    {
        Result InsertClassShedule(ClassSheduleRequest request);
        IEnumerable<ReadClassSheduleDTO> GetClassShedules();
        Result<ReadClassSheduleDTO> GetClassSheduleByID(int id);
        Result<ReadClassSheduleDTO> GetClassSheduleByDateTime(DateTime start, DateTime end);
    }
}
