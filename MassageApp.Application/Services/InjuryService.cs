using AutoMapper;
using MassageApp.Application.Interfaces;
using MassageApp.Application.ViewModels;
using MassageApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application.Services;

public class InjuryService : IInjuryService
{
    private readonly IInjuryRepository _injuryRepository;
    private readonly IMapper _mapper;
    public async Task<IEnumerable<InjuryVm>> GetAllInjuries(int patientId)
    {
       var injuries = await _injuryRepository.GetInjuryById(patientId);
        return _mapper.Map<IEnumerable<InjuryVm>>(injuries);

    }
}

