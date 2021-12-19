using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MassageApp.Application.Interfaces;
using MassageApp.Application.ViewModels;
using MassageApp.Domain.Interfaces;
using MassageApp.Domain.Models;
using  Microsoft.AspNetCore.Http;
namespace MassageApp.Application.Services;

internal class VisitService : IVisitService
{
    private readonly IGenericRepository? _genericRepository;
    private readonly IPatientRepository? _patientRepository;
    private readonly IVisitRepository? _visitRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IMapper _mapper;

    public VisitService(IGenericRepository genericRepository, IVisitRepository visitRepository,IPatientRepository patientRepository,
        IHttpContextAccessor httpContextAccessor,
        IMapper mapper)
    {
        _genericRepository = genericRepository;
        _visitRepository=visitRepository;
        _patientRepository = patientRepository;
        _httpContextAccessor = httpContextAccessor;
        _mapper = mapper; 
    }
    public async Task<IEnumerable<VisitVm>> GetAllVisits(string userId)
    {
        var visites = await _visitRepository.GetVisitList(userId);
        var visitesList = _mapper.Map<IEnumerable<VisitVm>>(visites);

        return visitesList;
    }

    public async Task<IEnumerable<VisitVm>> GetAllVisitsByPatient(int patientId)
    {
        var visites = await _visitRepository.GetVisitList(patientId);
        var visitesList = _mapper.Map<IEnumerable<VisitVm>>(visites);

        return visitesList;
    }

    public async Task<VisitVm> GetVisit(int visitId)
    {
        var visit =  await _visitRepository.GetVisitById(visitId);
        var visitVm = _mapper.Map<VisitVm>(visit);

        return visitVm;
    }

    public async Task AddVisit(VisitVm visitVm)
    {
        var visit = _mapper.Map<VisitVm, Visit>(visitVm);
        await _genericRepository.Add(visit);
    }

    public bool PatientBelondToUser(int patientId)
    {
        var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return _patientRepository.PatientBelongToUser(patientId, userId);
    }
}

