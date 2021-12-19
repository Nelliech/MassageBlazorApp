namespace MassageApp.Domain.Models;

public class SeriousIllness : BaseModel
{
    [Required]
    public string? Name { get; set; }
    public string? Description { get; set; }
    [Column(TypeName = "date")]
    public DateTime SeriousIllnessDate { get; set; }
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }
}
