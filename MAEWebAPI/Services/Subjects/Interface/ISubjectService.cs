using MAEWebAPI.Data.DTOs.Subjects;
using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Data.Result;

namespace MAEWebAPI.Services.Subjects.Interface
{
    public interface ISubjectService
    {
        Result<ReadSubjectDTO> InsertSubject(SubjectRequest subjectRequest);
        Result InsertMultiSubjects(List<SubjectRequest> subjectRequests);
        IEnumerable<ReadSubjectDTO> GetSubjects();
        ReadSubjectDTO GetSubjectByID(int id);
    }
}
