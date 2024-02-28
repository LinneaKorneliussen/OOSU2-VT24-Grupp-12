using System;
using System.Collections.Generic;
using PatientEntities;

namespace PatientDL
{
    public class UnitOfWork
    {
        /// <summary>
        /// Manages repositories for various entities within the application's data context, 
        /// providing a centralized access point for data operations and ensuring transactional integrity.
        /// </summary>
    
        private static UnitOfWork instance;
        private PatientContext context;

        public Repository<Appointment> AppointmentRepository { get; private set; }
        public Repository<Diagnosis> DiagnosisRepository { get; private set; }
        public Repository<Patient> PatientRepository { get; private set; }
        public Repository<Prescription> PrescriptionRepository { get; private set; }
        public Repository<Staff> StaffRepository { get; private set; }
        public Repository<Doctor> DoctorRepository { get; private set; }
        public Repository<Nurse> NurseRepository { get; private set; }

        // Using singelton pattern to ensure only one instance.
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
                instance.DoctorRepository = new Repository<Doctor> (instance.context);  
                instance.NurseRepository = new Repository<Nurse> (instance.context);    
            }
            return instance;
        }
        private UnitOfWork()
        {

        }

        public void Save()
        {
            context.SaveChanges();
        }
 
    }
}
