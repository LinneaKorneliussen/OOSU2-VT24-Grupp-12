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

            Patient p = new Patient("Lisa Svensson", "1994-05-18-6462", "Stora vävargatan 6", "070-2298675", "LisaSvensson@gmail.com");
            Patienter.Add(p);

            Diagnosis d = new Diagnosis(p, "Herpes", "Vatten");
            Diagnoses.Add(d);

            Diagnosis di = new Diagnosis(p, "Halsont", "Läsk");
            Diagnoses.Add(di);

            Prescription prescription = new Prescription(p, "Läkerol", "89 mg", new DateTime(2024, 2, 6, 10, 30, 0));
            Prescriptions.Add(prescription);

            Staff s = new Staff("Derek Shepherd", "Doctor", "Heja", "Neuro");
            Staff.Add(s);

            Patient p2 = new Patient("Amanda Larsson", "2001-02-06-8467", "Lilla Brogatan 12", "070-1234567", "AmandaLarsson@gmail.com");
            Patienter.Add(p2);

            Appointment a = new Appointment(p2, new DateTime(2024, 2, 9, 10, 30, 0), "Ont", s);
            Appointments.Add(a);

            Appointment a2 = new Appointment(p, new DateTime(2024, 2, 17, 10, 30, 0), "Mera ont", s);
            Appointments.Add(a2);

            SaveChanges();

            //#region Patients

            ////PatientRepository.Add(new Patient("Lisa Svensson", "1994-05-18-6462", "Stora vävargatan 6", "070-2298675", "LisaSvensson@gmail.com"));
            ////PatientRepository.Add(new Patient("Amanda Larsson", "2001-02-06-8467", "Lilla Brogatan 12", "070-1234567", "AmandaLarsson@gmail.com"));
            ////PatientRepository.Add(new Patient("Max Steén", "1996-12-11-1234", "PA Halls terass 2", "070-9876543", "MaxS@gmail.com"));
            ////PatientRepository.Add(new Patient("William Lendin", "2000-04-01-4321", "Brigadgatan 145", "073-8745900", "WilliamLendin@gmail.com"));
            ////PatientRepository.Add(new Patient("Felix Sandström", "1999-11-27-9999", "Odengatan 25", "070-0000000", "SandtrömFelix@gmail.com"));
            ////PatientRepository.Add(new Patient("Cleo Landegren", "2019-06-04-6643", "Göteborgsvägen 44", "070-2356896", "Cleo.landegren@gmail.com"));
            ////#endregion

            ////#region Staff
            ////StaffRepository.Add(new Staff(1, "Arizona Robbins", "Doctor", "1", "Pedriatics"));
            ////StaffRepository.Add(new Staff(2, "Derek Shepherd", "Doctor", "2", "Neuro"));
            ////StaffRepository.Add(new Staff(3, "Meredith Grey", "Doctor", "3", "General"));
            ////StaffRepository.Add(new Staff(4, "Christina Yang", "Doctor", "4", "Cardiothoracic"));
            ////StaffRepository.Add(new Staff(5, "Mark Sloan", "Doctor", "5", "ENT specialist"));
            ////StaffRepository.Add(new Staff(6, "April Kepner", "Doctor", "6", "Trauma"));
            //#endregion
        }

    }
}
