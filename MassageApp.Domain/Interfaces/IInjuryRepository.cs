using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Domain.Interfaces;

public interface IInjuryRepository 
{
    Task<IEnumerable<Injury>> GetInjuryList(int patientId);
    Task<Injury> GetInjuryById(int id);
}

