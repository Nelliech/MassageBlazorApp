namespace MassageApp.Domain.Models;
public class TypeMassage : BaseModel
{
    public string? Name { get; set; } //Relaksacyjny/ Leczniczy/inny
    public List<Visit>? Visits { get; set; }
}

