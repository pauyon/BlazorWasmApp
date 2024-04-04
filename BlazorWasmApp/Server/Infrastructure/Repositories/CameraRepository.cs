using BlazorWasmApp.Server.Domain.Repositories;
using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasmApp.Server.Infrastructure.Repositories
{
    public class CameraRepository : EntityRepository<Camera>, ICameraRepository
    {
        private readonly SqlServerDbContext _dbContext;

        public CameraRepository(SqlServerDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CameraHistory>> GetByIdTemporal(int id)
        {
            return await _dbContext.Set<Camera>()
                .TemporalAll()
                .OrderBy(c => EF.Property<DateTime>(c, "PeriodStart"))
                .Where(x => x.Id == id)
                .Select(x =>
                    new CameraHistory
                    {
                        Id = x.Id,
                        Make = x.Make,
                        Model = x.Model,
                        Serial = x.Serial,
                        PeriodStart = EF.Property<DateTime>(x, "PeriodStart"),
                        PeriodEnd = EF.Property<DateTime>(x, "PeriodEnd"),
                    }
                ).ToListAsync();
        }
    }
}
