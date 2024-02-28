using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PatientDL
{
    public class PatientContext : DbContext
    {
        /// <summary>
        /// Represents the database context for the system. The context provides access to the underlying data storage and manages the entity sets, 
        /// including patients, diagnoses, prescriptions, staff, and appointments. It´s responsible for configuring the database connection and entity mappings.
        /// </summary>

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }  
        public DbSet<Doctor> Doctors { get; set; }    
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
      

        public PatientContext()
        {
            //resetSeed();
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasIndex(p => p.PersonalNumber).IsUnique();
            modelBuilder.Entity<Doctor>().ToTable("Doctors");
            modelBuilder.Entity<Nurse>().ToTable("Nurses");


            base.OnModelCreating(modelBuilder);
        }

        #region Reset Seed Method
        public void resetSeed()
        {
            //////Database.EnsureDeleted();
            //Database.EnsureCreated();

            //Patient p = new Patient("Lisa Svensson", "1994-05-18-6462", "St Patric 6", "070-2298675", "LisaSvensson@gmail.com");
            //Patients.Add(p);

            //Patient p2 = new Patient("Amanda Larsson", "2001-02-06-8467", "East road 12", "070-1234567", "AmandaLarsson@gmail.com");
            //Patients.Add(p2);

            //Patient p3 = new Patient("Max Steén", "1996-12-11-1234", "Baker street 2", "070-9876543", "MaxS@gmail.com");
            //Patients.Add(p3);

            //Patient p4 = new Patient("William Lendin", "2000-04-01-4321", "Kings road", "073-8745900", "WilliamLendin@gmail.com");
            //Patients.Add(p4);

            //Patient p5 = new Patient("Felix Sandström", "1999-11-27-9999", "Carnaby street 25", "070-0000000", "SandtrömFelix@gmail.com");
            //Patients.Add(p5);

            //Patient p6 = new Patient("Cleo Landegren", "2019-06-04-6643", "Skinner street 44", "070-2356896", "Cleo.landegren@gmail.com");
            //Patients.Add(p6);


            //Diagnosis diagnos = new Diagnosis(p, "Allergy", "Steroid medication");
            //Diagnoses.Add(diagnos);

            //Diagnosis diagnos1 = new Diagnosis(p6, "Cold", "Nosespray and paracetamol");
            //Diagnoses.Add(diagnos1);

            //Diagnosis diagnos2 = new Diagnosis(p2, "Atopic Eczema", "Avoid triggers");
            //Diagnoses.Add(diagnos2);

            //Diagnosis diagnos3 = new Diagnosis(p3, "Diabetes type 2", "Insulin treatment");
            //Diagnoses.Add(diagnos3);

            //Prescription prescription = new Prescription(p, "Nasaleze Allergy Shield", "800 mg", new DateTime(2024, 4, 6, 10, 30, 0));
            //Prescriptions.Add(prescription);

            //Prescription prescription2 = new Prescription(p2, "Locobase Eczema Cream", "30 mg", new DateTime(2024, 5, 6, 5, 30, 0));
            //Prescriptions.Add(prescription2);

            //Prescription prescription3 = new Prescription(p3, "Locobase Eczema Cream", "30 mg", new DateTime(2024, 7, 6, 12, 00, 0));
            //Prescriptions.Add(prescription3);

            //Prescription prescription4 = new Prescription(p4, "Pioglitazone", "100 mg", new DateTime(2024, 8, 6, 9, 30, 0));
            //Prescriptions.Add(prescription4);

            //Doctor d = new Doctor("Derek Shepherd", "Iamderek", "Neurologist");
            //Doctors.Add(d);

            //Doctor d2 = new Doctor("Arizona Robbins", "Iamarizona", "General practitioner");
            //Doctors.Add(d2);

            //Doctor d3 = new Doctor("Derek Shepherd", "Iamderek", "Neurologist");
            //Doctors.Add(d3);

            //Doctor d4 = new Doctor("Meredith Grey", "Iammeredith", "General practitioner");
            //Doctors.Add(d4);

            //Doctor d5 = new Doctor("Christina Yang", "Iamchristina", "Medical specialists");
            //Doctors.Add(d5);

            //Doctor d6 = new Doctor("Mark Sloan", "Iammark", "Surgical specialists");
            //Doctors.Add(d6);

            //Doctor d7 = new Doctor("April Kepner", "Iamapril", "Endocrinologist");
            //Doctors.Add(d7);

            //Nurse n1 = new Nurse("Joe Jonas", "Iamjoe", "General Nurse");
            //Nurses.Add(n1);

            //Nurse n2 = new Nurse("Julia Robert", "Iamjulia", "Oncology Nurse");
            //Nurses.Add(n2);

            //Nurse n3 = new Nurse("Samuel Smith", "Iamsamuel", "Pediatric Nurse");
            //Nurses.Add(n3);

            //Appointment a = new Appointment(p2, new DateTime(2024, 2, 9, 10, 30, 0), "Feeling ill, sore throat", d);
            //Appointments.Add(a);

            //Appointment a2 = new Appointment(p3, new DateTime(2024, 2, 17, 10, 30, 0), "Stomach ache, tired", d6);
            //Appointments.Add(a2);

            //Appointment a3 = new Appointment(p, new DateTime(2024, 2, 17, 10, 30, 0), "Blurred vision, wounds", d3);
            //Appointments.Add(a3);

            //Appointment a4 = new Appointment(p6, new DateTime(2024, 2, 17, 10, 30, 0), "Headache, a chesty cough", d4);
            //Appointments.Add(a4);

            //Appointment a5 = new Appointment(p4, new DateTime(2024, 2, 17, 10, 30, 0), "Chills or shivering attacks", d7);
            //Appointments.Add(a5);

            //SaveChanges();

        }
        #endregion

    }
}
