﻿using AutoMapper;
using MAEWebAPI.Context;
using MAEWebAPI.Data.DTOs.Abstence;
using MAEWebAPI.Data.DTOs.SubjectAbstences;
using MAEWebAPI.Data.DTOs.Subjects;
using MAEWebAPI.Data.Models.Abstences;
using MAEWebAPI.Data.Requests.Abstences;
using MAEWebAPI.Data.Result;
using MAEWebAPI.Services.Abstences.Interface;
using MAEWebAPI.Services.Subjects.Interface;

namespace MAEWebAPI.Services.Abstences
{
    public class SubjectAbstencesService : ISubjectAbstencesService
    {
        SubjectContext subjectContext;
        IMapper mapper;
        
        ISubjectService subjectService;

        public SubjectAbstencesService(SubjectContext subjectContext, IMapper mapper, ISubjectService subjectService) 
        {
            this.subjectContext = subjectContext;
            this.mapper = mapper;
            this.subjectService = subjectService;
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

        public SubjectAbstenceRequest? GetSubjectAbstencesBySubjectName(string subjectName)
        {
            ReadSubjectDTO? readSubject = subjectService.GetSubjectByName(subjectName);

            ReadSubjectAbstencesDTO? readSubjectAbstences;

            if (readSubject != null)
            {
                readSubjectAbstences = mapper.Map<ReadSubjectAbstencesDTO>(
                    subjectContext.SubjectsAbstences.FirstOrDefault(
                        sbj => sbj.SubjectIDFK == readSubject.SubjectID));

                if (readSubjectAbstences != null)
                    return new SubjectAbstenceRequest
                    {
                        SubjectName = readSubject.Name,
                        AbstencesCount = readSubjectAbstences.AbstencesCount,
                        TotalClasses = readSubject.TotalClasses,
                        PresencePercent = 100 - (readSubjectAbstences.AbstencesCount * 100 / readSubject.TotalClasses)
                    };
                return new SubjectAbstenceRequest
                    {
                    SubjectName = readSubject.Name,
                        AbstencesCount = 0,
                        TotalClasses = readSubject.TotalClasses,
                        PresencePercent = 100
                    };

            }

            return null;
        }
    }
}
