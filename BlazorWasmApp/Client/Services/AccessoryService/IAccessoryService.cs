using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Models;

namespace BlazorWasmApp.Client.Services.AccessoryService
{
    public interface IAccessoryService : IService<Accessory, AccessoryHistory>
    {
    }
}
