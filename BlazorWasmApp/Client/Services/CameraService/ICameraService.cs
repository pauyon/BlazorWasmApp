using BlazorWasmApp.Shared.Domain.Entities;
using BlazorWasmApp.Shared.Domain.Models;

namespace BlazorWasmApp.Client.Services.CameraService
{
    public interface ICameraService : IService<Camera, CameraHistory>
    {
    }
}
