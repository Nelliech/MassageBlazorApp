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
using AntDesign;
using MassageApp.Domain.Interfaces;
using MassageApp.Application.Interfaces;
using MassageApp.Application.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace MassageApp.Pages.MassagePages;

public partial class PatientDetails
{
    [Inject]
    public IPatientService PatientService { get; set; }
    [Inject]
    public NavigationManager NavManager { get; set; }
    [Inject]
    public IHttpContextAccessor? HttpContextAccessor { get; set; }

    public PatientVm? Patient = new();
    public IEnumerable<AllergyVm> Allergy { get; set; }
    [Parameter]
    public int patientId { get; set; }
    public bool IsAnyVisitNotPaid { get; set; }
    public async Task<PatientVm> Get()
    {
        Patient = await Task.Run(() => PatientService.GetPatient(patientId));
        return Patient;
    }
    protected override async Task OnInitializedAsync()
    {
        
        Patient = await Get();      
        AgreeUserId();

    }
    //public bool IsVisitPaid(IEnumerable<Allergy> allergies)
    //{
    //    var isAny = allergies.Any();
    //}
    public void AgreeUserId()
    {
        string userId= HttpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        if (Patient.UserId != userId)
        {
            NavManager.NavigateTo("Massage/Patient/");
        }
    }
    public void Is()
    {

    }
}
