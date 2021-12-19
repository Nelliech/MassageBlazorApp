namespace MassageApp.Domain.Interfaces;

public interface IGenericRepository
{
    Task<T> Add<T>(T newModel) where T : class;
    Task<T> Delete<T>(int modelId) where T : class;
    Task<T> Update<T>(T model) where T : class;
}

