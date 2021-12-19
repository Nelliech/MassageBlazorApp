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
internal class AllergyService : IAllergyService
{
    private readonly IAllergyRepository _allergyRepository;
    private readonly IMapper _mapper;
    public AllergyService(IAllergyRepository allergyRepository, IMapper mapper)
    {
        _allergyRepository = allergyRepository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<AllergyVm>> GetAllAllergies(int patientId)
    {
            var allergies = await _allergyRepository.GetAllergiesByPatientId(patientId);
            return _mapper.Map<IEnumerable<AllergyVm>>(allergies);
    }
}

