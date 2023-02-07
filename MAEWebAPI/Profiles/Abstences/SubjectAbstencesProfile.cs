using AutoMapper;
using MAEWebAPI.Data.DTOs.SubjectAbstences;
using MAEWebAPI.Data.Models.Abstences;

namespace MAEWebAPI.Profiles.Abstences
{
    public class SubjectAbstencesProfile : Profile
    {
        public SubjectAbstencesProfile() 
        {
            CreateMap<SubjectAbstences, ReadSubjectAbstencesDTO>();
            CreateMap<ReadSubjectAbstencesDTO, SubjectAbstences>();
        }
    }
}
