
namespace MassageApp.Domain.Interfaces;

public interface IAllergyRepository  
{
    Task<IEnumerable<Allergy>> GetAllergiesByPatientId(int patientId);
}

