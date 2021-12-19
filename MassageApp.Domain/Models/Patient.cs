namespace MassageApp.Domain.Models;

public class Patient : BaseModel
{
    [Column(TypeName ="Date")]
    public DateTime CreationDate { get; set; }
    [Required]
    public string? PatientName { get; set; }
    public string PhoneNumber { get; set; } = default!;
    
    public string? AdditionalInformation { get; set; }
    public string UserId { get; set; }= default!;
    public User? User { get; set; }
    
    public ICollection<Visit>? Visits { get; set; } //Wizyty
    public ICollection<Allergy>? Allergies { get; set; }    //Alergie
    public ICollection<Injury>? Injurys { get; set; }   //Przebyte kontuzje
    public ICollection<SeriousIllness>? SeriousIllnesses { get; set; }  //Przebyte poważne choroby




}
