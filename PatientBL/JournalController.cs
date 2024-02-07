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
        public IList<Appointment> GetAppointmentList()
        {
            return unitOfWork.AppointmentRepository.GetAll().ToList();
        }
        #endregion
    }

}
