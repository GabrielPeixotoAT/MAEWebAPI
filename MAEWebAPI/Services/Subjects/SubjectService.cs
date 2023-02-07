using AutoMapper;
using MAEWebAPI.Context;
using MAEWebAPI.Data.DTOs.Subjects;
using MAEWebAPI.Data.Models.Subjects;
using MAEWebAPI.Data.Requests.Subjects;
using MAEWebAPI.Data.Result;
using MAEWebAPI.Services.Subjects.Interface;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Xml.Linq;

namespace MAEWebAPI.Services.Subjects
{
    public class SubjectService : ISubjectService
    {
        private SubjectContext subjectContext;
        private IMapper mapper;

        public SubjectService(SubjectContext subjectContext, IMapper mapper) 
        {
            this.subjectContext = subjectContext;
            this.mapper = mapper;
        }

        public Result<ReadSubjectDTO> InsertSubject(SubjectRequest subjectRequest)
        {
            Subject subject = mapper.Map<Subject>(subjectRequest);

            if(GetReadSubjectByName(subject.Name) != null)
                return new ResultError<ReadSubjectDTO>("This subject is already registered");

            subjectContext.Subjects.Add(subject);
            subjectContext.SaveChanges();

            return new ResultSuccess<ReadSubjectDTO>(mapper.Map<ReadSubjectDTO>(subject));
        }

        public Result InsertMultiSubjects(List<SubjectRequest> subjectRequests)
        {
            foreach(SubjectRequest subjectRequest in subjectRequests)
            {
                var result = InsertSubject(subjectRequest);
                if (result.hasError) 
                    return new ResultError(result.message);
            }

            return new ResultSuccess("Success");
        }

        public IEnumerable<ReadSubjectDTO> GetSubjects()
        {
            return mapper.Map<List<ReadSubjectDTO>>(subjectContext.Subjects.ToList());
        }

        public ReadSubjectDTO? GetReadSubjectByName(string name)
        {
            Subject? subject = subjectContext.Subjects.FirstOrDefault(sub => sub.Name == name);

            return mapper.Map<ReadSubjectDTO>(subject);

        }

        public ReadSubjectDTO GetSubjectByID(int id)
        {
            Subject? subject = subjectContext.Subjects.FirstOrDefault(sub => sub.SubjectID == id);

            return mapper.Map<ReadSubjectDTO>(subject);
        }
    }
}
