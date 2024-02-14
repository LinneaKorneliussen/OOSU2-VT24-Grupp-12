using PatientDL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientBL
{
    public class JournalController
    {
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
