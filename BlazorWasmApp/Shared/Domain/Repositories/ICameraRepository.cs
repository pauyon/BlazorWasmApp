using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Models;
using BlazorWasmApp.Shared.Domain.Repositories;

namespace BlazorWasmApp.Server.Domain.Repositories
{
    public interface ICameraRepository : IEntityRepository<Camera>, IEntityTemporalRepository<CameraHistory>
    {
    }
}
