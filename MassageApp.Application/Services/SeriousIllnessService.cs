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

public class SeriousIllnessService : ISeriousIllnessService
{
    private readonly ISeriousIllnessRepository _seriousIllnessRepository;
    private readonly IMapper _mapper;
    public async Task<IEnumerable<SeriousIllnessVm>> GetAllSeriousIllnesses(int patientId)
    {
        var seriousIllnesses = await _seriousIllnessRepository.GetSeriousIllnessList(patientId);
        return _mapper.Map<IEnumerable<SeriousIllnessVm>>(seriousIllnesses);
    }
}

