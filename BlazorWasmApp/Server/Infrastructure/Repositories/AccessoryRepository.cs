using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Repositories;

namespace BlazorWasmApp.Server.Infrastructure.Repositories
{
    public class AccessoryRepository : EntityRepository<Accessory>, IAccessoryRepository
    {
        public AccessoryRepository(SqlServerDbContext dbContext) : base(dbContext)
        {
        }
    }
}
