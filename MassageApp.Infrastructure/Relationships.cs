using MassageApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MassageApp.Infrastructure;

public static class Relationships
{
    public static void RelationshipsSeeder(this ModelBuilder builder)
    {
        //// Many to Many Visit and Massage Preparations
        //builder.Entity<VisitMassagePreparation>()
        //        .HasKey(t => new { t.VisitId, t.MassagePreparationId });

        //builder.Entity<VisitMassagePreparation>()
        //    .HasOne(pt => pt.Visit)
        //    .WithMany(p => p.VisitMassagePreparations)
        //    .HasForeignKey(pt => pt.VisitId);
        //builder.Entity<VisitMassagePreparation>()
        //    .HasOne(pt => pt.MassagePreparation)
        //    .WithMany(p => p.VisitMassagePreparations)
        //    .HasForeignKey(pt => pt.MassagePreparationId);

        ////Many to Many Patient and Allergy
        //builder.Entity<PatientAllergy>()
        //    .HasKey(t=> new {t.PatientId, t.AllergyId});

        //builder.Entity<PatientAllergy>()
        //    .HasOne(pt => pt.Patient)
        //    .WithMany(p => p.PatientAllergies)
        //    .HasForeignKey(pt => pt.PatientId);
        //builder.Entity<PatientAllergy>()
        //    .HasOne(pt => pt.Allergy)
        //    .WithMany(p => p.PatientAllergies)
        //    .HasForeignKey(pt => pt.AllergyId);

    }
}
