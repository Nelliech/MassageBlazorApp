using AutoMapper;
using MassageApp.Application.Mapping;
using MassageApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application.ViewModels;

public class PatientDetailsVm : IMapFrom<Patient>
{
    public int Id { get; set; }
    [DisplayName("Numer Telefonu")]
    public string PhoneNumber { get; set; }
    [DisplayName("Imię")]
    public string? FirstName { get; set; }
    [DisplayName("Nazwisko")]
    public string? LastName { get; set; }
    [DisplayName("Data Dodania")]
    public DateTime CreationDate { get; set; }
    public string AdditionalInformation { get; set; }

    public List<Allergy> Allergies { get; set; }
    public List<Injury> Injurys { get; set; }
    public List<SeriousIllness> SeriousIllnesses { get; set; }
    public string UserId { get; set; }
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Patient, PatientDetailsVm>().ReverseMap();
    }
}

