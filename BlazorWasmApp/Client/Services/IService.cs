namespace BlazorWasmApp.Client.Services
{
    public interface IService<TEntity, THistory> 
        where TEntity : class
        where THistory : class
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity?> GetById(int id);

        Task<IEnumerable<THistory>?> GetByIdTemporal(int id);

        Task<TEntity> Add(TEntity entity);

        Task<bool> Update(TEntity entity);

        Task<bool> Delete(TEntity entity);
    }
}
