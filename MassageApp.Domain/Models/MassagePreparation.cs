namespace MassageApp.Domain.Models;

public class MassagePreparation : BaseModel
{
    public string? Name { get; set; }
    public int VisitId { get; set; }
    public Visit? Visit { get; set; }

}

