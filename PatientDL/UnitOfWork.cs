using System;
using System.Collections.Generic;
using PatientEntities;

namespace PatientDL
{
    public class UnitOfWork
    {
        private PatientContext context;
        public Repository<Appointment> AppointmentRepository
        {
            get; private set;
        }

        public Repository<Diagnosis> DiagnosisRepository
        {
            get; private set;
        }

        public Repository<Patient> PatientRepository
        {
            get; private set;
        }

        public Repository<Prescription> PrescriptionRepository
        {
            get; private set;
        }

        public Repository<Staff> StaffRepository
        {
            get; private set;
        }


        public UnitOfWork()
        {
            context = new PatientContext(); 
            AppointmentRepository = new Repository<Appointment>(context);
            DiagnosisRepository = new Repository<Diagnosis>(context);
            PatientRepository = new Repository<Patient>(context);
            PrescriptionRepository = new Repository<Prescription>(context);
            StaffRepository = new Repository<Staff>(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
