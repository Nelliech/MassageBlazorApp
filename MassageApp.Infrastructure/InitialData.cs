using MassageApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageApp.Infrastructure
{
    public static class InitialData
    {
        public static void InitialSeeder(this ModelBuilder builder)
        {
            builder.Entity<TypeMassage>().HasData(
                new TypeMassage() { Id = 1, Name = "Relaksacyjny"},
                new TypeMassage() { Id = 2, Name = "Leczniczy" },
                new TypeMassage() { Id = 3, Name = "Sportowy" },
                new TypeMassage() { Id = 4, Name = "Ceremonialny" },
                new TypeMassage() { Id = 5, Name = "Inny" }

                );
                
        }
    }
}
