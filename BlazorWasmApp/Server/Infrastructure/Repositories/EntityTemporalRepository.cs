using BlazorWasmApp.Shared.Domain.Repositories;

namespace BlazorWasmApp.Server.Infrastructure.Repositories
{
    public class EntityTemporalRepository<THistory> : IEntityTemporalRepository<THistory>
        where THistory : class
    {
        public virtual Task<IEnumerable<THistory>> GetByIdTemporal(int id)
        {
            throw new NotImplementedException();
        }
    }
}
