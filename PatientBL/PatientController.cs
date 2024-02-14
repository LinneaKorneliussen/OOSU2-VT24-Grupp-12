using PatientDL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientBL
{
    public class PatientController
    {
        private PatientRepository patientRepository;
        public PatientController()
        {
            patientRepository = new PatientRepository();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return patientRepository.GetPatient(patientPersonalNumber);
        }
        #endregion

        #region Register new patient Method
        public void CreateNewPatient(string name, string personalNumber, string address, string phoneNumber, string emailAddress)
        {
            patientRepository.CreateNewPatient(name, personalNumber, address, phoneNumber, emailAddress);   
        }
        #endregion

        #region Update patient information Method
        public void UpdatePatientInfo(Patient patientToUpdate, int choice, string newValue)
        {
            patientRepository.UpdatePatientInfo(patientToUpdate, choice, newValue); 
        }

        #endregion
    }
}
