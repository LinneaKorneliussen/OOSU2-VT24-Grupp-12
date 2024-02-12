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
        private UnitOfWork unitOfWork;
        public JournalController()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

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
