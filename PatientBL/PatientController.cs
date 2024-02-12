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
        private UnitOfWork unitOfWork;

        public PatientController()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return unitOfWork.PatientRepository.FirstOrDefault(p => p.PersonalNumber == patientPersonalNumber);
        }
        #endregion

        #region Register new patient Method
        public void CreateNewPatient(string name, string personalNumber, string address, string phoneNumber, string emailAddress)
        {
            Patient patient = new Patient(name, personalNumber, address, phoneNumber, emailAddress);
            unitOfWork.PatientRepository.Add(patient);
            unitOfWork.Save();
        }
        #endregion

        #region Update patient information Method
        public void UpdatePatientInfo(Patient patientToUpdate, int choice, string newValue)
        {
            if (patientToUpdate != null)
            {
                switch (choice)
                {
                    case 0:
                        patientToUpdate.Name = newValue;
                        unitOfWork.Save();
                        break;
                    case 1:
                        patientToUpdate.Address = newValue;
                        unitOfWork.Save();
                        break;
                    case 2:
                        patientToUpdate.Phonenumber = newValue;
                        unitOfWork.Save();
                        break;
                    case 3:
                        patientToUpdate.EmailAddress = newValue;
                        unitOfWork.Save();
                        break;

                    default:
                    break;
                
                }

            }
         
        }

        #endregion
    }
}
