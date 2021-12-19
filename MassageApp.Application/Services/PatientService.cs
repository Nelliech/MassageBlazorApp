using AutoMapper;
using MassageApp.Application.Interfaces;
using MassageApp.Application.ViewModels;
using MassageApp.Domain.Interfaces;
using MassageApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application.Services;

internal class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;
    private readonly IGenericRepository _genericRepository;
    private readonly IMapper _mapper;
    public PatientService(IPatientRepository patientRepository,IGenericRepository genericRepository, IMapper mapper)
    {
        _patientRepository = patientRepository;
        _genericRepository = genericRepository;
        _mapper = mapper;
    }

    public async Task AddPatient(PatientVm patientVm)
    {
        var patient = _mapper.Map<PatientVm,Patient>(patientVm);
        await _genericRepository.Add(patient);
    }

    public async Task<IEnumerable<PatientVm>> GetAllPatients(string userId)
    {
        var patients =  await _patientRepository.GetPatientsList(userId);
        var listPatient =  _mapper.Map<IEnumerable<PatientVm>>(patients);

        return listPatient;
    }

    public async Task<PatientVm> GetPatient(int patientId)
    {
        var patient = await _patientRepository.GetPatientById(patientId);
        return _mapper.Map<PatientVm>(patient);
    }
}
