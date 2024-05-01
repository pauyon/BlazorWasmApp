using BlazorWasmApp.Configurations;
using BlazorWasmApp.Shared.Domain.Entities;

namespace BlazorWasmApp.Client.Services.CameraService;

public class CameraService : Service<Camera>, ICameraService
{
    public CameraService(HttpClient httpClient) : base(httpClient, SiteConstants.ApiEndpoints.Camera)
    {
    }
}
