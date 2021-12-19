using System.Security.Claims;
using MassageApp.Application.Interfaces;
using MassageApp.Application.ViewModels;
using MassageApp.Domain.Interfaces;
using MassageApp.Domain.Models;
using Microsoft.AspNetCore.Components;

namespace MassageApp.Pages.MassagePages;

public  partial class AddVisit
{
    [Inject]
    protected IVisitService? visitService { get; set; }
    [Inject]
    public NavigationManager NavManager { get; set; }
    [Inject]
    protected IHttpContextAccessor? HttpContextAccessor { get; set; }
    [Parameter]
    public int patientId { get; set; }
    public VisitVm VisitVm { get; set; }
    
    
    string style = "display: block;height:30px;line-height:30px";
    private bool isChecked = true;

    protected override async Task OnInitializedAsync()
    {
        AgreeUserId();

        VisitVm = new VisitVm
        {
            MassagePreparations = new List<MassagePreparation>(),
            Drugs = new List<Drug>(),
            VisitDate = DateTime.Today
        };

    }
    private void AgreeUserId()
    {
        if (!visitService.PatientBelondToUser(patientId))
        {
            NavManager.NavigateTo("Massage/Patient/");
        }
    }

    private async void SubmitVisit()
    {
        VisitVm.PatientId = patientId;
        DidVisitFromDate(VisitVm.VisitDate);
        await visitService.AddVisit(VisitVm);
        NavManager.NavigateTo("Massage/Patient/"+patientId);
    }

    private void DidVisitFromDate(DateTime date)
    {
        if (date <=DateTime.Today)
        {
            VisitVm.DidVisit = true;
        }
    }

}

