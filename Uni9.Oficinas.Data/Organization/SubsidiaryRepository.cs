using Uni9.Oficinas.Data.Shared;
using Uni9.Oficinas.Domain.Organization;
using Uni9.Oficinas.Domain.Organization.Repositories;

namespace Uni9.Oficinas.Data.Organization
{
    public class SubsidiaryRepository : RepositoryBase<Subsidiary>, ISubsidiaryRepository
    {
        public SubsidiaryRepository(string connectionString, string database, string collectionName) 
            : base(connectionString, database, collectionName)
        {
        }
    }
}
