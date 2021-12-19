using Microsoft.AspNetCore.Identity;

namespace MassageApp.Domain.Models;

public class User : IdentityUser
{
    public ICollection<Patient>? Patients { get; set; }
        


}

