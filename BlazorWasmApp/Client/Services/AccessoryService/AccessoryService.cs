using BlazorWasmApp.Configurations;
using BlazorWasmApp.Shared.Domain.Entities;

namespace BlazorWasmApp.Client.Services.AccessoryService;

public class AccessoryService : Service<Accessory>, IAccessoryService
{
    public AccessoryService(HttpClient httpClient) : base(httpClient, SiteConstants.ApiEndpoints.Accessory)
    {
    }
}
