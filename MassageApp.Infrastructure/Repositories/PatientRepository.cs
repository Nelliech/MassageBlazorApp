namespace MassageApp.Infrastructure.Repositories;

public class PatientRepository : IPatientRepository
{
    private readonly MassageAppDbContext _context;
    public PatientRepository(MassageAppDbContext context)
    {
        _context = context;
    }
    public async Task<Patient> GetPatientById(int patientId)
    {
        return await _context.Patients
            .Include(e=>e.Allergies)
            .Include(e=>e.Injurys)
            .Include(e=>e.SeriousIllnesses)
            .Include(e=>e.Visits)
                .ThenInclude(e=>e.TypeMassage)
                    .FirstOrDefaultAsync(p => p.Id == patientId);

    }

    public bool PatientBelongToUser(int patientId, string userId)
    {
        return  _context.Patients.Any(p => p.Id == patientId && p.UserId == userId);
    }

    public  async Task<IEnumerable<Patient>> GetPatientsList(string userId)
    {
        //return  await _context.Patients
        //    .Where(p => p.UserId == userId);  //?????????????????

        return await _context.Patients.Where(p => p.UserId == userId).ToListAsync(); 

    }
}

