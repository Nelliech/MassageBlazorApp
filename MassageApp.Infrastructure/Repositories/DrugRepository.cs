

namespace MassageApp.Infrastructure.Repositories;

public class DrugRepository : IDrugRepository
{
    private readonly MassageAppDbContext _context;

    public DrugRepository(MassageAppDbContext context)
    {
            _context= context;
    }
    public async Task<Drug> GetDrugById(int id)
    {
        return await _context.Drugs.FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Drug>> GetDrugList(int visitId)
    {
        return await _context.Drugs.Where(p=>p.VisitId == visitId).ToListAsync();
    }
}

