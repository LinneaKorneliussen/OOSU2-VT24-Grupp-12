using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDL
{
    public class JournalRepository
    {
        /// <summary>
        /// This repository class serves as a bridge for accessing patient and appointment data 
        /// within the application, with a focus on supporting journaling activities. 
        /// </summary>

        private UnitOfWork unitOfWork;
        public JournalRepository()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return unitOfWork.PatientRepository.FirstOrDefault(p => p.PersonalNumber == patientPersonalNumber);
        }
        #endregion

        #region Get appointment List Method
        public IQueryable<Appointment> GetAppointmentList(Patient patient)
        {
            IQueryable<Appointment> appointments = unitOfWork.AppointmentRepository.Query();

            var result = from x in appointments
                         where x.Patient.PersonalNumber.Equals(patient.PersonalNumber)
                         orderby x.DateAndTime ascending
                         select x;
            return result;
        }
        #endregion
    }
}
