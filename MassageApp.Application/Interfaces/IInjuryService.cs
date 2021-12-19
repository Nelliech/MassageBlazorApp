using MassageApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application.Interfaces;

public interface IInjuryService
{
    Task<IEnumerable<InjuryVm>> GetAllInjuries(int patientId);
}

