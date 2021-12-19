
namespace MassageApp.Infrastructure.Repositories;

public class InjuryRepository : IInjuryRepository
{
    private readonly MassageAppDbContext _context;

    public InjuryRepository(MassageAppDbContext context)
    {
        _context=context;
    }
    public async Task<Injury> GetInjuryById(int id)
    {
        return await _context.Injuries.FirstOrDefaultAsync(p=>p.Id==id);
    }

    public async Task<IEnumerable<Injury>> GetInjuryList(int patientId)
    {
        return await _context.Injuries.Where(p => p.PatientId==patientId).ToListAsync();
    }
}

