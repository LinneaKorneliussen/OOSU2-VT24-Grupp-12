using System;
using System.Collections.Generic;
using PatientEntities;

namespace PatientDL
{
    public class UnitOfWork
    {
        private static UnitOfWork instance;
        private PatientContext context;

        public Repository<Appointment> AppointmentRepository { get; private set; }
        public Repository<Diagnosis> DiagnosisRepository { get; private set; }
        public Repository<Patient> PatientRepository { get; private set; }
        public Repository<Prescription> PrescriptionRepository { get; private set; }
        public Repository<Staff> StaffRepository { get; private set; }

        private UnitOfWork()
        {
            // Användning av "lazy initialization" för PatientContext
        }

        public static UnitOfWork GetInstance()
        {
            if (instance == null)
            {
                instance = new UnitOfWork();
                instance.context = new PatientContext();
                instance.AppointmentRepository = new Repository<Appointment>(instance.context);
                instance.DiagnosisRepository = new Repository<Diagnosis>(instance.context);
                instance.PatientRepository = new Repository<Patient>(instance.context);
                instance.PrescriptionRepository = new Repository<Prescription>(instance.context);
                instance.StaffRepository = new Repository<Staff>(instance.context);
            }
            return instance;
        }

        public void Save()
        {
            context.SaveChanges();
        }
 
    }
}
