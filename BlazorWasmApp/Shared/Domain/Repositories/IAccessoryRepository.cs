using BlazorWasmApp.Server.Domain.Repositories;
using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Models;

namespace BlazorWasmApp.Shared.Domain.Repositories
{
    public interface IAccessoryRepository : IEntityRepository<Accessory>, IEntityTemporalRepository<AccessoryHistory>
    {
    }
}
