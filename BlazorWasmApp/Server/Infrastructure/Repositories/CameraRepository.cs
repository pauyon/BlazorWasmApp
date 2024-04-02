using BlazorWasmApp.Server.Domain.Repositories;
using BlazorWasmApp.Shared.Domain.Entities;

namespace BlazorWasmApp.Server.Infrastructure.Repositories
{
    public class CameraRepository : EntityRepository<Camera>, ICameraRepository
    {
        public CameraRepository(SqlServerDbContext dbContext) : base(dbContext)
        {
        }
    }
}
