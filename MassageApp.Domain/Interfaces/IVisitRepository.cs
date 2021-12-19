
namespace MassageApp.Domain.Interfaces;

public interface IVisitRepository
{
    Task<IEnumerable<Visit>> GetVisitList(int patientId);
    Task<IEnumerable<Visit>> GetVisitList(string userId);
    Task<Visit> GetVisitById(int id);
}

