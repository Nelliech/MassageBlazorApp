namespace MassageApp.Domain.Models;

public class Visit : BaseModel
{
    
    public bool DidVisit { get; set; }=false;

    [Column(TypeName ="date")]
    public DateTime VisitDate { get; set; }
    [Required]
    public string? ReasonVisit { get; set; }
    public string? DiagnosticMoreOrLess { get; set; }
    public int TypeMassageId { get; set; }
    public TypeMassage? TypeMassage { get; set; }
    public string? IfTypeMassageOther { get; set; } // If TypeMassage=3/inne/other
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }
    public ICollection<MassagePreparation>? MassagePreparations { get; set; }
    public ICollection<Drug>? Drugs { get; set; }
    //After the Visit
    public bool IsPaid { get; set; } = false;
    public string? PatientsOpinion { get; set; } // Patient's Opinion
    public string? RateAfterVisit { get; set; } // 
}

