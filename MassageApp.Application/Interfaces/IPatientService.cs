using MassageApp.Application.ViewModels;
using MassageApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassageApp.Domain.Interfaces;

namespace MassageApp.Application.Interfaces;

public interface IPatientService  
{
    Task<IEnumerable<PatientVm>> GetAllPatients(string userId);
    Task AddPatient(PatientVm patientVm);
    Task<PatientVm> GetPatient(int patientId);

}
