using MassageApp.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection service)
    {
        service.AddScoped<IPatientRepository, PatientRepository>();
        service.AddScoped<IGenericRepository, GenericRepository>();
        service.AddScoped<IVisitRepository, VisitRepository>();

        return service;
    }
}
