using AutoMapper;
using MAEWebAPI.Data.DTOs.ClassShedule;
using MAEWebAPI.Data.Models.Subjects;
using MAEWebAPI.Data.Requests.Subjects;

namespace MAEWebAPI.Profiles.Subjects
{
    public class ClassSheduleProfile : Profile
    {
        public ClassSheduleProfile()
        {
            CreateMap<ClassSheduleRequest, CreateClassSheduleDTO>();
            CreateMap<ClassSchedule, ReadClassSheduleDTO>();
            CreateMap<CreateClassSheduleDTO, ClassSchedule>();
        }
    }
}
