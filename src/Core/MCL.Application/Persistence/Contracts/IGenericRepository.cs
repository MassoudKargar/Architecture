﻿namespace MCL.Application.Persistence.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> UpdateAsync(T entity);
    Task<T> AddAsync(T entity);
    Task<T> DeleteAsync(int id); 
}