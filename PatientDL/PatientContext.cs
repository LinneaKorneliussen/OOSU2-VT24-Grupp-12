using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDL
{
    public class PatientContext : DbContext
    {
        public DbSet<Patient> Patienter { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }  
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public PatientContext()
        {
            resetSeed(); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("PatientMS.json", true, true) 
                .Build()                                      
                .GetConnectionString("PatientMS"));
            base.OnConfiguring(optionsBuilder);
        }

        public void resetSeed()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

            Patient p = new Patient("Lisa Svensson", "1994-05-18-6462", "St Patric 6", "070-2298675", "LisaSvensson@gmail.com");
            Patienter.Add(p);

            Patient p2 = new Patient("Amanda Larsson", "2001-02-06-8467", "East road 12", "070-1234567", "AmandaLarsson@gmail.com");
            Patienter.Add(p2);

            Patient p3 = new Patient("Max Steén", "1996-12-11-1234", "Baker street 2", "070-9876543", "MaxS@gmail.com");
            Patienter.Add(p3);

            Patient p4 = new Patient("William Lendin", "2000-04-01-4321", "Kings road", "073-8745900", "WilliamLendin@gmail.com");
            Patienter.Add(p4);

            Patient p5 = new Patient("Felix Sandström", "1999-11-27-9999", "Carnaby street 25", "070-0000000", "SandtrömFelix@gmail.com");
            Patienter.Add(p5);

            Patient p6 = new Patient("Cleo Landegren", "2019-06-04-6643", "Skinner street 44", "070-2356896", "Cleo.landegren@gmail.com");
            Patienter.Add(p6);


            Diagnosis d = new Diagnosis(p, "Allergy", "Steroid medication");
            Diagnoses.Add(d);

            Diagnosis d2 = new Diagnosis(p, "Cold", "Nosespray and paracetamol");
            Diagnoses.Add(d2);

            Diagnosis d3 = new Diagnosis(p, "Atopic Eczema", "Avoid triggers");
            Diagnoses.Add(d3);

            Diagnosis d4 = new Diagnosis(p, "Diabetes type 2", "Insulin treatment");
            Diagnoses.Add(d4);

            Prescription prescription = new Prescription(p, "Nasaleze Allergy Shield", "800 mg", new DateTime(2024, 2, 6, 10, 30, 0));
            Prescriptions.Add(prescription);

            Prescription prescription2 = new Prescription(p, "Locobase Eczema Cream", "30 mg", new DateTime(2024, 2, 6, 50, 30, 0));
            Prescriptions.Add(prescription2);

            Prescription prescription3 = new Prescription(p, "Locobase Eczema Cream", "30 mg", new DateTime(2024, 2, 6, 12, 00, 0));
            Prescriptions.Add(prescription3);

            Prescription prescription4 = new Prescription(p, "Pioglitazone", "100 mg", new DateTime(2024, 2, 6, 09, 30, 0));
            Prescriptions.Add(prescription4);

            Staff s = new Staff("Derek Shepherd", "Doctor", "Iamderek", "Neurologist");
            Staff.Add(s);

            Staff s2 = new Staff("Arizona Robbins", "Doctor", "Iamarizona", "General practitioner");
            Staff.Add(s2);

            Staff s3 = new Staff("Meredith Grey", "Doctor", "Iammeredith", "General practitioner");
            Staff.Add(s3);

            Staff s4 = new Staff("Christina Yang", "Doctor", "Iamchristina", "Medical specialists");
            Staff.Add(s4);

            Staff s5 = new Staff("Mark Sloan", "Doctor", "Iammark", "Surgical specialists");
            Staff.Add(s5);

            Staff s6 = new Staff("April Kepner", "Doctor", "Iamapril", "Endocrinologist");
            Staff.Add(s6);


            Appointment a = new Appointment(p2, new DateTime(2024, 2, 9, 10, 30, 0), "Feeling ill, sore throat", s);
            Appointments.Add(a);

            Appointment a2 = new Appointment(p, new DateTime(2024, 2, 17, 10, 30, 0), "Stomach ache, tired", s);
            Appointments.Add(a2);

            Appointment a3 = new Appointment(p, new DateTime(2024, 2, 17, 10, 30, 0), "Blurred vision, cuts or wounds that heal slowly", s);
            Appointments.Add(a3);

            Appointment a4 = new Appointment(p, new DateTime(2024, 2, 17, 10, 30, 0), "Headache, a dry chesty cough", s);
            Appointments.Add(a4);

            SaveChanges();

        }

    }
}
