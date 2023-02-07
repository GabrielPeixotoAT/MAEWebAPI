using AutoMapper;
using MAEWebAPI.Data.DTOs.SchoolDay;
using MAEWebAPI.Data.Models.Subjects;
using MAEWebAPI.Data.Requests.Subjects;

namespace MAEWebAPI.Profiles.Subjects
{
    public class SchoolDayProfile : Profile
    {
        public SchoolDayProfile()
        {
            CreateMap<SchoolDayRequest, SchoolDay>();
            CreateMap<SchoolDay, ReadSchoolDayDTO>();
            CreateMap<SchoolDayRequest, CreateSchoolDayDTO>();
            CreateMap<CreateSchoolDayDTO, SchoolDay>();
        }
    }
}
