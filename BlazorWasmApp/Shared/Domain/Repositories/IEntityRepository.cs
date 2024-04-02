﻿using System.Linq.Expressions;

namespace BlazorWasmApp.Server.Domain.Repositories
{
    public interface IEntityRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? predicate = null);
        Task<T?> Get(Expression<Func<T, bool>> predicate, bool tracked = true);
        Task<T> Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        Task<bool> Delete(int id);
        Task RemoveRange(IEnumerable<T> entities);
        Task<bool> Update(T entity);
        Task SaveChanges();
    }
}
