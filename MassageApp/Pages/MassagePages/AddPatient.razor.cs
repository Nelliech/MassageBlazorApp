using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using MassageApp;
using MassageApp.Shared;
using MassageApp.Areas.Identity.Pages.Account;
using MassageApp.Domain.Interfaces;
using MassageApp.Domain.Models;
using System.Security.Claims;
using AntDesign.TableModels;
using System.Text.Json;
using MassageApp.Application.ViewModels;
using MassageApp.Application.Interfaces;

namespace MassageApp.Pages.MassagePages;

public partial class AddPatient
{
    [Inject]
    protected IGenericRepository? GenericRepository { get; set; }
    [Inject]
    protected IPatientService? PatientService { get; set; }
    [Inject]
    protected IHttpContextAccessor? HttpContextAccessor { get; set; }
    
    public Patient Patient { get; set; }
    public SeriousIllness SeriousIllness { get; set; }
    public PatientVm PatientVm { get; set; }

    protected override async Task OnInitializedAsync()
    {
        PatientVm = new PatientVm
        {
            Allergies = new List<Allergy>(),
            SeriousIllnesses = new List<SeriousIllness>(),
            Injurys = new List<Injury>(),
            Visits = new List<Visit>(),
        };
        Patient = new Patient { 

            Allergies = new List<Allergy>(),           
            SeriousIllnesses = new List<SeriousIllness>(),
            Injurys= new List<Injury>(),


        };
    }
    private async void SubmitPatient()
    {       
        PatientVm.UserId=HttpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        PatientVm.CreationDate=DateTime.Today;
        await PatientService.AddPatient(PatientVm);
        //await GenericRepository.Add<PatientVm>(PatientVm);
    }
}
