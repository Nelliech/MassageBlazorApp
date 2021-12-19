namespace MassageApp.Infrastructure.Repositories;

public class GenericRepository : IGenericRepository
{
    private readonly MassageAppDbContext _context;
    public GenericRepository(MassageAppDbContext context)
    {
        _context = context;
    }
    public async Task<T> Add<T>(T newModel) where T : class
    {
        _context.Set<T>().Add(newModel);
        await _context.SaveChangesAsync();
        return newModel;
    }

    public async Task<T> Delete<T>(int modelId) where T : class
    {
        var model = _context.Set<T>().Find(modelId);
        if (model != null)
        {
            _context.Set<T>().Remove(model);
            await _context.SaveChangesAsync();         
            return model;
        }
        return null;    
    }

    public async Task<T> Update<T>(T model) where T : class
    {
        _context.Set<T>().Update(model);
        await _context.SaveChangesAsync();
        return model;
    }
}

