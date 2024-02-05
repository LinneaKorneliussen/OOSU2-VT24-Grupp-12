using System;
using System.Collections.Generic;
using PatientEntities;

namespace PatientDL
{
    public class UnitOfWork
    {
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
            AppointmentRepository = new Repository<Appointment>();
            DiagnosisRepository = new Repository<Diagnosis>();
            PatientRepository = new Repository<Patient>();
            PrescriptionRepository = new Repository<Prescription>();
            StaffRepository = new Repository<Staff>();

            if (StaffRepository.IsEmpty())
            {
                Fill();
            }
        }
        public void Save()
        {

        }

        private void Fill()
        {
            #region Patients

            PatientRepository.Add(new Patient("Lisa Svensson", "1994-05-18-6462", "Stora vävargatan 6", "070-2298675", "LisaSvensson@gmail.com"));
            PatientRepository.Add(new Patient("Amanda Larsson", "2001-02-06-8467", "Lilla Brogatan 12", "070-1234567", "AmandaLarsson@gmail.com"));
            PatientRepository.Add(new Patient("Max Steén", "1996-12-11-1234", "PA Halls terass 2", "070-9876543", "MaxS@gmail.com"));
            PatientRepository.Add(new Patient("William Lendin", "2000-04-01-4321", "Brigadgatan 145", "073-8745900", "WilliamLendin@gmail.com"));
            PatientRepository.Add(new Patient("Felix Sandström", "1999-11-27-9999", "Odengatan 25", "070-0000000", "SandtrömFelix@gmail.com"));
            PatientRepository.Add(new Patient("Cleo Landegren", "2019-06-04-6643", "Göteborgsvägen 44", "070-2356896", "Cleo.landegren@gmail.com"));
            #endregion

            #region Staff
            StaffRepository.Add(new Staff(1, "Arizona Robbins", "Doctor", "1", "Pedriatics"));
            StaffRepository.Add(new Staff(2, "Derek Shepherd", "Doctor", "2", "Neuro"));
            StaffRepository.Add(new Staff(3, "Meredith Grey", "Doctor", "3", "General"));
            StaffRepository.Add(new Staff(4, "Christina Yang", "Doctor", "4", "Cardiothoracic"));
            StaffRepository.Add(new Staff(5, "Mark Sloan", "Doctor", "5", "ENT specialist"));
            StaffRepository.Add(new Staff(6, "April Kepner", "Doctor", "6", "Trauma"));
            #endregion
        }

    }
}
