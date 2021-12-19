using MassageApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application.Interfaces;

public interface ISeriousIllnessService
{
    Task<IEnumerable<SeriousIllnessVm>> GetAllSeriousIllnesses(int patientId);
}

