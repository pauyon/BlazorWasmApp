using BlazorWasmApp.Shared.Domain.Repositories;

namespace BlazorWasmApp.Server.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICameraRepository CameraRepository { get; }
        IAccessoryRepository AccessoryRepository { get; }
        int Save();
    }
}
