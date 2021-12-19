namespace MassageApp.Infrastructure.Repositories;
public class SeriousIllnessRepository : ISeriousIllnessRepository
{
    private readonly MassageAppDbContext _context;
    public SeriousIllnessRepository(MassageAppDbContext context)
    {
        _context=context;
    }
    public async Task<SeriousIllness> GetSeriousIllnessById(int id)
    {
        return await _context.SeriousIllnesses.FirstOrDefaultAsync(p => p.Id==id);
    }

    public async Task<IEnumerable<SeriousIllness>> GetSeriousIllnessList(int patientId)
    {
        return await _context.SeriousIllnesses.Where(p=>p.PatientId==patientId).ToListAsync();
    }
}

