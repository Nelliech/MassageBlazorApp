using MassageApp.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MassageApp.Infrastructure;

public class MassageAppDbContext : IdentityDbContext
{
    // public DbSet<User> Users { get; set; }
    public DbSet<Patient>? Patients { get; set; }
    public DbSet<Allergy>? Allergies { get; set; }
    public DbSet<Injury>? Injuries { get; set; }
    public DbSet<SeriousIllness>? SeriousIllnesses { get; set; }

    public DbSet<Visit>? Visits { get; set; }
    public DbSet<MassagePreparation>? MassagePreparations { get; set; }
    public DbSet<TypeMassage>? TypeMassages { get; set; }
    public DbSet<Drug>? Drugs { get; set; }


    public MassageAppDbContext(DbContextOptions options) :base(options)
    {

    }

        
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.RelationshipsSeeder();
        builder.InitialSeeder();
    }       
}

