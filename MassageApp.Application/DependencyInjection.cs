using MassageApp.Application.Interfaces;
using MassageApp.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection service)
    {
        service.AddScoped<IPatientService, PatientService>();
        service.AddScoped<IVisitService, VisitService>();

        service.AddAutoMapper(Assembly.GetExecutingAssembly());
        return service; 
    }
}

