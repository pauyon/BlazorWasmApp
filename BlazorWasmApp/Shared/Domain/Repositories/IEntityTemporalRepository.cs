namespace BlazorWasmApp.Shared.Domain.Repositories
{
    public interface IEntityTemporalRepository<THistory> 
        where THistory : class
    {
        Task<IEnumerable<THistory>> GetByIdTemporal(int id); 
    }
}
