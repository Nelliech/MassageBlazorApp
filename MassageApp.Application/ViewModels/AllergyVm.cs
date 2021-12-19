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

public class AllergyVm :  IMapFrom<Allergy>
{
    public int Id { get; set; }
    [DisplayName("Alergen")]
    public string Name { get; set; }
    public int PatientId { get; set; }




    public void Mapping(Profile profile)
    {
        profile.CreateMap<Allergy, AllergyVm>().ReverseMap();
    }
}

