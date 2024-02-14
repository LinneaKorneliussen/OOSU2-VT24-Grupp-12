using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDL
{
    public  class PrescriptionRepository
    {
        private UnitOfWork unitOfWork;
        public PrescriptionRepository()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return unitOfWork.PatientRepository.FirstOrDefault(p => p.PersonalNumber == patientPersonalNumber);
        }
        #endregion

        #region Add Prescription Method
        public void AddPrescription(Patient p, string medicineName, string dose, DateTime prescriptionDate)
        {
            Prescription newPrescription = new Prescription(p, medicineName, dose, prescriptionDate);
            unitOfWork.PrescriptionRepository.Add(newPrescription);
            unitOfWork.Save();
        }
        #endregion
    }
}
