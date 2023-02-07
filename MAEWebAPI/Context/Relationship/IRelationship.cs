using Microsoft.EntityFrameworkCore;

namespace MAEWebAPI.Context.Relationship
{
    public interface IRelationship
    {
        void CreateRelationship(ModelBuilder builder);
        void DefaultValues(ModelBuilder builder);
    }
}
