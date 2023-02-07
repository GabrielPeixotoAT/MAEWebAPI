using MAEWebAPI.Data.DTOs.Abstence;
using MAEWebAPI.Data.Requests.Abstences;
using MAEWebAPI.Data.Result;

namespace MAEWebAPI.Services.Abstences.Interface
{
    public interface IAbstenceService
    {
        Result<CreateAbstenceDTO> InsertAbstence(AbstenceRequest request);
        Result<CreateAbstenceDTO> InsertAbstenceDay(AbstenceRequest request);

        IEnumerable<ReadAbstenceDTO> GetAbstences();
        Result<ReadAbstenceDTO?> GetAbstenceByID(int id);
    }
}
