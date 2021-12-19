namespace MassageApp.Domain.Interfaces;

public interface IDrugRepository 
{
    Task<IEnumerable<Drug>> GetDrugList(int visitId);
    Task<Drug> GetDrugById(int id);
}

