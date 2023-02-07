using MAEWebAPI.Data.DTOs.Abstence;
using MAEWebAPI.Data.DTOs.SubjectAbstences;
using MAEWebAPI.Data.Models.Abstences;
using MAEWebAPI.Data.Requests.Abstences;
using MAEWebAPI.Data.Result;

namespace MAEWebAPI.Services.Abstences.Interface
{
    public interface ISubjectAbstencesService
    {
        Result<SubjectAbstences> CreateSubjectAbstences(ReadAbstenceDTO subjectAbstences);
        IEnumerable<ReadSubjectAbstencesDTO> GetSubjectAbstences();
        SubjectAbstences? GetSubjectAbstencesBySubjectID(int subjectID);
        SubjectAbstenceRequest? GetSubjectAbstencesBySubjectName(string subjectName);
    }
}
