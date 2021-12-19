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
using MassageApp.Domain.Models;
using System.Security.Claims;
using AntDesign.TableModels;
using System.Text.Json;
using MassageApp.Application.ViewModels;
using MassageApp.Application.Interfaces;

namespace MassageApp.Pages.MassagePages;

public partial class Patients
{
    [Inject]
    protected IPatientService? PatientService { get; set; }
    [Inject]
    protected IPatientRepository? PatientRepository { get; set; }
    [Inject]
    protected IHttpContextAccessor? HttpContextAccessor { get; set; }

    // public IEnumerable<Patient>? Patientlist { get; set; }
    
    public IEnumerable<Patient>? ListPatients = Array.Empty<Patient>();
    
    public IEnumerable<PatientVm>? PatientListVm { get; set; }

    public async Task<IEnumerable<PatientVm>> Get()
    {
        var usierId = HttpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        PatientListVm = await Task.Run(() => PatientService.GetAllPatients(usierId));

        //ListPatients =  await Task.Run(() => PatientRepository.GetPatientsList(usierId));

        return PatientListVm;
    }
    protected override async Task OnInitializedAsync()
    {

        PatientListVm = await Get();
      
    }
   
}
