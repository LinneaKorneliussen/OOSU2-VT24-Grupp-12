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
        private UnitOfWork unitOfWork;
        public DiagnosisController()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

        #region Add diagnosis Method
        public void AddDiagnosis(Patient p, string diagnosis, string treatmentplan)
        {
            Diagnosis newdiagnosis = new Diagnosis(p, diagnosis, treatmentplan);
            unitOfWork.DiagnosisRepository.Add(newdiagnosis);
            unitOfWork.Save();
            Console.WriteLine($"Diagnosis added successfully for {p.Name}");
        }
        #endregion
    }
}
