using AutoMapper;
using MassageApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application.ViewModels;

public class SeriousIllnessVm
{
    public int Id { get; set; }
    [DisplayName("Nazwa choroby")]
    public string Name { get; set; }
    [DisplayName("Szczegóły")]
    public string Description { get; set; }
    public void Mapping(Profile profile)
    {
        profile.CreateMap<SeriousIllness, SeriousIllnessVm>().ReverseMap();
    }
}

