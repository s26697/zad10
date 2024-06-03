using Microsoft.EntityFrameworkCore;
using WebApplication10.Models;

namespace WebApplication10.Context;

public class MyDbContext :DbContext
{
    
    
    
    public MyDbContext()
    {
        
    }
    
    public MyDbContext(DbContextOptions< MyDbContext> options)
        : base(options)
    {
       
    }
    
    
    public DbSet<Doctor> Doctors { get; set; }
    
    public DbSet<Patient> Patients { get; set; }
    
    public DbSet<Prescription> Prescriptions { get; set; }
    
    public DbSet<Medicament> Medicaments { get; set; }
    
    public DbSet<Prescription_Medicament> PrescriptionMedicaments { get; set; }
    
   
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Prescription_Medicament>()
            .HasKey(pm => new { pm.IdPrescription, pm.IdMedicament });

        modelBuilder.Entity<Prescription_Medicament>()
            .HasOne(pm => pm.Prescriptions)
            .WithMany(p => p.PrescriptionMedicaments)
            .HasForeignKey(pm => pm.IdPrescription);

        modelBuilder.Entity<Prescription_Medicament>()
            .HasOne(pm => pm.Medicaments)
            .WithMany(m => m.PrescriptionMedicaments)
            .HasForeignKey(pm => pm.IdMedicament);
    }
    
    
    
}