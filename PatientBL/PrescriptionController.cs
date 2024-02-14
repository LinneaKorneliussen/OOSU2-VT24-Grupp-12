using PatientDL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientBL
{
    public class PrescriptionController
    {
        private PrescriptionRepository prescriptionRepository;
        public PrescriptionController()
        {
            prescriptionRepository = new PrescriptionRepository();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return prescriptionRepository.GetPatient(patientPersonalNumber);
        }
        #endregion

        #region Add Prescription Method
        public void AddPrescription(Patient p, string medicineName, string dose, DateTime prescriptionDate)
        {
            prescriptionRepository.AddPrescription(p, medicineName, dose, prescriptionDate);
        }
        #endregion
    }

}