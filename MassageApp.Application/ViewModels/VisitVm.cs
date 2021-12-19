using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MassageApp.Application.Mapping;
using MassageApp.Domain.Models;

namespace MassageApp.Application.ViewModels;

public class VisitVm : IMapFrom<Visit>
{
    public int Id { get; set; }
    public bool DidVisit { get; set; }
    public DateTime VisitDate { get; set; }
    [Required]
    public string? ReasonVisit { get; set; }
    public string? DiagnosticMoreOrLess { get; set; }
    public int TypeMassageId { get; set; }
    public TypeMassage TypeMassage { get; set; }
    public string? IfTypeMassageOther { get; set; } 
    public int PatientId { get; set; }
    [ValidateComplexType]
    public List<MassagePreparation>? MassagePreparations { get; set; }
    [ValidateComplexType]
    public List<Drug>? Drugs { get; set; }
    //After the Visit
    public bool IsPaid { get; set; } = false;
    public string? PatientsOpinion { get; set; } // Patient's Opinion
    public string? RateAfterVisit { get; set; } // 
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Visit, VisitVm>().ReverseMap();
    }
}

