using MassageApp.Application.ViewModels;

namespace MassageApp.Application.Interfaces;

public interface IVisitService
{
    Task<IEnumerable<VisitVm>> GetAllVisits(string userId);
    Task<IEnumerable<VisitVm>> GetAllVisitsByPatient(int patientId);
    Task<VisitVm> GetVisit(int visitId);
    Task AddVisit(VisitVm visitVm);
    bool PatientBelondToUser(int patientId);
}