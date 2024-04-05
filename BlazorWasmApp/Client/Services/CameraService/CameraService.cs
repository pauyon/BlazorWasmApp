using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Models;

namespace BlazorWasmApp.Client.Services.CameraService
{
    public class CameraService : Service<Camera>, ICameraService
    {
        public CameraService(HttpClient httpClient) : base(httpClient, "camera")
        {
        }
    }
}
