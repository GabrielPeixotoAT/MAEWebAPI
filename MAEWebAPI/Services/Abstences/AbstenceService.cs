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

        ISubjectAbstencesService subjectAbstencesService;

        public AbstenceService(SubjectContext subjectContext, IMapper mapper, ISubjectAbstencesService subjectAbstencesService)
        {
            this.subjectContext = subjectContext;
            this.mapper = mapper;
            this.subjectAbstencesService = subjectAbstencesService;
        }

        public Result<CreateAbstenceDTO> InsertAbstence(AbstenceRequest request)
        {
            CreateAbstenceDTO create = mapper.Map<CreateAbstenceDTO>(request);
            
            //Verifica se falta já existe

            Abstence abstence = mapper.Map<Abstence>(create);

            subjectContext.Abstences.Add(abstence);
            subjectContext.SaveChanges();

            Result<SubjectAbstences> result = subjectAbstencesService.CreateSubjectAbstences(mapper.Map<ReadAbstenceDTO>(abstence));

            if (result.hasError)
                return new ResultError<CreateAbstenceDTO>(result.message);

            return new ResultSuccess<CreateAbstenceDTO>(create);
        }

        public Result<CreateAbstenceDTO> InsertAbstenceDay(AbstenceRequest request)
        {
            throw new NotImplementedException();
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
