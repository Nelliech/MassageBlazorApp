using AutoMapper;
using MassageApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application.ViewModels;

public class InjuryVm
{
    public int Id { get; set; }
    [DisplayName("Kontuzja")]
    public string Name { get; set; }
    [DisplayName("Data kontuzji")]
    public DateTime InjuryDate { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Injury, InjuryVm>().ReverseMap();
    }
}

