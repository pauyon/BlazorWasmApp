using BlazorWasmApp.Client.Services.CameraService;
using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Models;

namespace BlazorWasmApp.Client.Services.AccessoryService
{
    public class AccessoryService : Service<Accessory, AccessoryHistory>, IAccessoryService
    {
        public AccessoryService(HttpClient httpClient) : base(httpClient, "accessory")
        {
        }
    }
}
