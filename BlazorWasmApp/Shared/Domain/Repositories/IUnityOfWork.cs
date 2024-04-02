namespace BlazorWasmApp.Server.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICameraRepository CameraRepository { get; }
        int Save();
    }
}
