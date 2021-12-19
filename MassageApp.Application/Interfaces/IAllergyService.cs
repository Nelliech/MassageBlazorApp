using MassageApp.Application.ViewModels;
using MassageApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application.Interfaces;

public interface IAllergyService
{
    Task<IEnumerable<AllergyVm>> GetAllAllergies(int patientId);
    
}

