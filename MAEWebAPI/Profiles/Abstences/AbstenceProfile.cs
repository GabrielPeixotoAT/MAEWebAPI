using AutoMapper;
using MAEWebAPI.Data.DTOs.Abstence;
using MAEWebAPI.Data.Models.Abstences;
using MAEWebAPI.Data.Requests.Abstences;

namespace MAEWebAPI.Profiles.Abstences
{
    public class AbstenceProfile : Profile
    {
        public AbstenceProfile()
        {
            CreateMap<AbstenceRequest, CreateAbstenceDTO>();
            CreateMap<CreateAbstenceDTO, Abstence>();
            CreateMap<Abstence, ReadAbstenceDTO>();
        }
    }
}
