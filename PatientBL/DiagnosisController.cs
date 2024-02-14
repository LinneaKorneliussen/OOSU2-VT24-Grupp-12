using PatientDL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientBL
{
    public class DiagnosisController
    {
        private DiagnosisRepository diagnosisRepository;
        public DiagnosisController()
        {
            diagnosisRepository = new DiagnosisRepository();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return diagnosisRepository.GetPatient(patientPersonalNumber);
        }
        #endregion

        #region Add diagnosis Method
        public void AddDiagnosis(Patient p, string diagnosis, string treatmentplan)
        {
            diagnosisRepository.AddDiagnosis(p, diagnosis, treatmentplan);
        }
        #endregion
    }
}
