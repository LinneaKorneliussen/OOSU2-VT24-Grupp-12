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
                    case 1:
                        patientToUpdate.Name = newValue;
                        break;
                    case 2:
                        patientToUpdate.Address = newValue;
                        break;
                    case 3:
                        patientToUpdate.Phonenumber = newValue;
                        break;
                    case 4:
                        patientToUpdate.EmailAddress = newValue;
                        break;
                    default:
                        Console.WriteLine("Incorrect option, please try again!");
                        return;
                }

                Console.WriteLine($"{patientToUpdate.Name}'s information updated!");
            }
            else
            {
                Console.WriteLine($"Patient with personal number {patientToUpdate} not found.");
            }
        }

        #endregion
    }
}
