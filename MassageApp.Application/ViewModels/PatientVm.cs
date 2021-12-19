using AutoMapper;
using MassageApp.Application.Mapping;
using MassageApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application.ViewModels;

public class PatientVm : IMapFrom<Patient>
{
    public int Id { get; set; }
    [DisplayName("Numer Telefonu")]
    public string? PhoneNumber { get; set; }
    [Required]
    [DisplayName("Nazwa Pacjenta")]
    public string? PatientName { get; set; }

    [DisplayName("Data Dodania")]
    public DateTime CreationDate { get; set; }
    public string AdditionalInformation { get; set; }
    public bool IsPaid { get; set; }
    public bool DidVisit { get; set; }
    [ValidateComplexType]
    public List<Allergy> Allergies { get; set; }
    [ValidateComplexType]
    public List<Injury> Injurys { get; set; }
    [ValidateComplexType]
    public List<SeriousIllness> SeriousIllnesses { get; set; }
    public List<Visit> Visits { get; set; }

    public string UserId { get; set; }
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Patient, PatientVm>().ReverseMap();
    }
}

