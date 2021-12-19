namespace MassageApp.Domain.Models;

public class Drug : BaseModel
{
    [Required]
    public string? Name { get; set; }
    public string? Reason { get; set; }
    public int VisitId { get; set; }
    public Visit? Visit { get; set; }

}

