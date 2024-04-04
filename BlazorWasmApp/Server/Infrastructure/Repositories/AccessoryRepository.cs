using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Models;
using BlazorWasmApp.Shared.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasmApp.Server.Infrastructure.Repositories
{
    public class AccessoryRepository : EntityRepository<Accessory>, IAccessoryRepository
    {
        private readonly SqlServerDbContext _dbContext;

        public AccessoryRepository(SqlServerDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<AccessoryHistory>> GetByIdTemporal(int id)
        {
            return await _dbContext.Set<Accessory>()
                .TemporalAll()
                .OrderBy(c => EF.Property<DateTime>(c, "PeriodStart"))
                .Where(x => x.Id == id)
                .Select(x =>
                    new AccessoryHistory
                    {
                        Id = x.Id,
                        Make = x.Make,
                        Model = x.Model,
                        PeriodStart = EF.Property<DateTime>(x, "PeriodStart"),
                        PeriodEnd = EF.Property<DateTime>(x, "PeriodEnd"),
                    }
                ).ToListAsync();
        }
    }
}
