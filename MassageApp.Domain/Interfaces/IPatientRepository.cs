using MassageApp.Domain.Models;

namespace MassageApp.Domain.Interfaces;

public interface IPatientRepository 
{
    Task<IEnumerable<Patient>> GetPatientsList(string userId);
    Task<Patient> GetPatientById(int id);
    bool PatientBelongToUser(int patientId, string userId);

}

