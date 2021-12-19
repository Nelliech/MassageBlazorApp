using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Domain.Interfaces;

public interface ISeriousIllnessRepository
{
    Task<IEnumerable<SeriousIllness>> GetSeriousIllnessList(int patientId);
    Task<SeriousIllness> GetSeriousIllnessById(int id);
}

