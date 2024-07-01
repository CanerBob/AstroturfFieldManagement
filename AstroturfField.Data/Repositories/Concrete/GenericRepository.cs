namespace AstroturfField.Data.Repositories.Concrete;
public class GenericRepository<T>: IGenericRepository<T> where T : class, IEntityBase, new()
{
	private readonly AppDbContext context;
	private DbSet<T> Table { get => context.Set<T>(); }

	public GenericRepository(AppDbContext context)
	{
		this.context = context;
	}
	public async Task AddAsync(T entity)
	{
		await Table.AddAsync(entity);
	}
	public async Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate = null,params Expression<Func<T,object>>[] includeProperties) 
	{
		IQueryable<T> query = Table;
		if(predicate != null)
			query = query.Where(predicate);
		if (includeProperties.Any())
			foreach (var item in includeProperties)
				query = query.Include(item);
		return await query.ToListAsync();
    }
	public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
	{
		IQueryable<T> query = Table;
		query = query.Where(predicate);
		if(includeProperties.Any())
			foreach (var item in includeProperties)
				query = query.Include(item);
		return await query.SingleAsync();
	}
	public async Task<T> GetByGuidAsync(Guid id)
	{
		return await Table.FindAsync(id);
	}
	public async Task<T> UpdateAsync(T entity)
	{
		await Task.Run(() => Table.Update(entity));
		return entity;
	}
	public async Task DeleteAsync(T entity)
	{
		await Task.Run(() => Table.Remove(entity));
	}
	public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
	{
		return await Table.AnyAsync(predicate);
	}
}