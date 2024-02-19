using PatientDL;
using PatientEntities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientBL
{
    public class JournalController
    {
        /// <summary>
        /// Returns a patient based on personalnumber
        /// Fetches a list of appointments for a given patient from the journal repository and returns it
        /// </summary>

        private JournalRepository journalRepository;
        public JournalController()
        {
            journalRepository = new JournalRepository();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return journalRepository.GetPatient(patientPersonalNumber);
        }
        #endregion

        #region Get appointment List Method
        public IQueryable<Appointment> GetAppointmentList(Patient patient)
        {
           return journalRepository.GetAppointmentList(patient);
        }

        #endregion
    }

}
