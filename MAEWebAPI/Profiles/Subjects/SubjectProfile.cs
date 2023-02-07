using AutoMapper;
using MAEWebAPI.Data.DTOs.Subjects;
using MAEWebAPI.Data.Models.Subjects;
using MAEWebAPI.Data.Requests.Subjects;

namespace MAEWebAPI.Profiles.Subjects
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<SubjectRequest, Subject>();
            CreateMap<Subject, ReadSubjectDTO>();

        }
    }
}
