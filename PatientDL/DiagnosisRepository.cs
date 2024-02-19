using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDL
{
    public class DiagnosisRepository
    {
        /// <summary>
        ///  Repository class responsible for mediating data access and coordinating operations pertaining to diagnoses and related entities within the application. 
        ///  Encapsulates the logic for fetching patient details and adding new diagnoses
        /// </summary>

        private UnitOfWork unitOfWork;
        public DiagnosisRepository()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return unitOfWork.PatientRepository.FirstOrDefault(p => p.PersonalNumber == patientPersonalNumber);
        }
        #endregion

        #region Add diagnosis Method
        public void AddDiagnosis(Patient p, string diagnosis, string treatmentplan)
        {
            Diagnosis newdiagnosis = new Diagnosis(p, diagnosis, treatmentplan);
            unitOfWork.DiagnosisRepository.Add(newdiagnosis);
            unitOfWork.Save();
        }
        #endregion
    }
}
