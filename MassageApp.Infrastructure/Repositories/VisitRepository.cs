

namespace MassageApp.Infrastructure.Repositories;

public class VisitRepository : IVisitRepository
{
    private readonly MassageAppDbContext _context;

    public VisitRepository(MassageAppDbContext context)
    {
        _context=context;
    }

    public async Task<IEnumerable<Visit>> GetVisitList(string userId)
    {
        return await _context.Visits.Where(p => p.Patient.UserId == userId).ToListAsync();
    }

    public async Task<Visit> GetVisitById(int id)
    {
        return await _context.Visits.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Visit>> GetVisitList(int patientId)
    {
        return await _context.Visits.Where(p=>p.PatientId==patientId).ToListAsync();
    }
}

