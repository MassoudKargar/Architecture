namespace MCL.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public GenericRepository(ApplicationDbContext context)
    {
        Context = context;
    }

    private ApplicationDbContext Context { get; }
    public async Task<T> GetAsync(int id, CancellationToken cancellationToken)
    {
        return await Context.Set<T>().FindAsync(id, cancellationToken);
    }
    public async Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await Context.Set<T>().ToListAsync(cancellationToken);
    }
    public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        Context.Entry(entity).State = EntityState.Modified;
        await Context.SaveChangesAsync(cancellationToken);
    }
    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
    {
        await Context.AddAsync(entity, cancellationToken);
        await Context.SaveChangesAsync(cancellationToken);
        return entity;
    }
    public async Task DeleteAsync(T entity, CancellationToken cancellationToken)
    {
        Context.Set<T>().Remove(entity);
        await Context.SaveChangesAsync(cancellationToken);
    }
    public async Task<bool> ExistAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await GetAsync(id, cancellationToken);
        return entity != null;
    }

}
