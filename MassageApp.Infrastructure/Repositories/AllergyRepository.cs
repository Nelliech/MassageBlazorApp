namespace MassageApp.Infrastructure.Repositories;

public class AllergyRepository : IAllergyRepository
{
    private readonly MassageAppDbContext _context;
    
    public AllergyRepository( MassageAppDbContext context)
    {
        _context=context;
    }

    public async Task<IEnumerable<Allergy>> GetAllergiesByPatientId(int patientId)
    {
        return await _context.Allergies
            .Where(p=>p.PatientId==patientId)
            .ToListAsync();
    }
}

