using AutoMapper;
using MAEWebAPI.Context;
using MAEWebAPI.Data.DTOs.Abstence;
using MAEWebAPI.Data.DTOs.SubjectAbstences;
using MAEWebAPI.Data.Models.Abstences;
using MAEWebAPI.Data.Result;
using MAEWebAPI.Services.Abstences.Interface;

namespace MAEWebAPI.Services.Abstences
{
    public class SubjectAbstencesService : ISubjectAbstencesService
    {
        SubjectContext subjectContext;
        IMapper mapper;

        public SubjectAbstencesService(SubjectContext subjectContext, IMapper mapper) 
        {
            this.subjectContext = subjectContext;
            this.mapper = mapper;
        }

        public Result<SubjectAbstences> CreateSubjectAbstences(ReadAbstenceDTO abstence)
        {
            SubjectAbstences? abstences = GetSubjectAbstencesBySubjectID(abstence.SubjectIDFK);

            if (abstences != null)
            {
                abstences.AbstencesCount++;
                subjectContext.SaveChanges();

                return new ResultSuccess<SubjectAbstences>(abstences);
            }

            SubjectAbstences subjectAbstences = new SubjectAbstences
            {
                SubjectIDFK = abstence.SubjectIDFK,
                AbstencesCount = 1
            };

            subjectContext.SubjectsAbstences.Add(subjectAbstences);
            subjectContext.SaveChanges();

            return new ResultSuccess<SubjectAbstences>(subjectAbstences);
        }

        public IEnumerable<ReadSubjectAbstencesDTO> GetSubjectAbstences()
        {
            return mapper.Map<List<ReadSubjectAbstencesDTO>>(subjectContext.SubjectsAbstences.ToList());
        }

        public SubjectAbstences? GetSubjectAbstencesBySubjectID(int subjectID)
        {
            return subjectContext.SubjectsAbstences.SingleOrDefault(sa => sa.SubjectIDFK == subjectID);
        }
    }
}
