using AutoMapper;
using MAEWebAPI.Context;
using MAEWebAPI.Data.DTOs.Abstence;
using MAEWebAPI.Data.Models.Abstences;
using MAEWebAPI.Data.Requests.Abstences;
using MAEWebAPI.Data.Result;
using MAEWebAPI.Services.Abstences.Interface;

namespace MAEWebAPI.Services.Abstences
{
    public class AbstenceService : IAbstenceService
    {
        SubjectContext subjectContext;
        IMapper mapper;

        public AbstenceService(SubjectContext subjectContext, IMapper mapper)
        {
            this.subjectContext = subjectContext;
            this.mapper = mapper;
        }

        public Result<CreateAbstenceDTO> InsertAbstence(AbstenceRequest request)
        {
            CreateAbstenceDTO create = mapper.Map<CreateAbstenceDTO>(request);
            
            //Verifica se falta já existe

            Abstence abstence = mapper.Map<Abstence>(create);

            subjectContext.Abstences.Add(abstence);
            subjectContext.SaveChanges();

            return new ResultSuccess<CreateAbstenceDTO>(create);
        }

        public IEnumerable<ReadAbstenceDTO> GetAbstences()
        {
            return mapper.Map<List<ReadAbstenceDTO>>(subjectContext.Abstences.ToList());
        }

        public Result<ReadAbstenceDTO?> GetAbstenceByID(int id)
        {
            ReadAbstenceDTO read = mapper.Map<ReadAbstenceDTO>(subjectContext.Abstences.FirstOrDefault(abs => abs.AbstenceID == id));

            if (read != null)
                return new ResultSuccess<ReadAbstenceDTO?>(read);

            return new ResultError<ReadAbstenceDTO?>("Not found");
        }
    }
}
