using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PatientEntities;
using System;
using System.Collections.Generic;
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


        //public PatientContext()
        //{
        //    //INSTRUCTION: Run program once and make a login (might "freeze" ~10 sec, just wait), close down, then comment resetSeed()-line below away. Then the database will be presistent onwards 

        //    resetSeed(); //uncomment to (re)create database & fill/seed example data
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=PatientMS;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public static void resetSeed(PatientContext context)
        {

            Patient p = new Patient("Lisa Svensson", "1994-05-18-6462", "Stora vävargatan 6", "070-2298675", "LisaSvensson@gmail.com");
            context.Patienter.Add(p);

            Diagnosis d = new Diagnosis(p, "Herpes", "Vatten");
            context.Diagnoses.Add(d);

            Diagnosis di = new Diagnosis(p, "Halsont", "Läsk");
            context.Diagnoses.Add(di);

            Prescription prescription = new Prescription(p, "Läkerol", "89 mg", new DateTime(2024, 2, 6, 10, 30, 0));
            context.Prescriptions.Add(prescription);

            Staff s = new Staff("Derek Shepherd", "Doctor", "2", "Neuro");
            context.Staff.Add(s);

            Patient p2 = new Patient("Amanda Larsson", "2001-02-06-8467", "Lilla Brogatan 12", "070-1234567", "AmandaLarsson@gmail.com");
            context.Patienter.Add(p2);

            Appointment a = new Appointment(p2, new DateTime(2024, 2, 9, 10, 30, 0), "Ont", s);
            context.Appointments.Add(a);

            Appointment a2 = new Appointment(p, new DateTime(2024, 2, 17, 10, 30, 0), "Mera ont", s);
            context.Appointments.Add(a2);


            context.SaveChanges();
        }



    }
}
