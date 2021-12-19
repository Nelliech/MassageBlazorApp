namespace MassageApp.Domain.Models;

public class Allergy : BaseModel
{
    [Required]
    public string? Name { get; set; }
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }
}

