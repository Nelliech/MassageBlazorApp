namespace MassageApp.Domain.Models;

public class Injury : BaseModel
{
    [Required]
    public string? Name { get; set; }
    [Column(TypeName = "date")]
    public DateTime InjuryDate { get; set; }
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }
}

