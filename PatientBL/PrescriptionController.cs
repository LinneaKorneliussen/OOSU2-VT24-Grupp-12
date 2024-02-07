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
        private UnitOfWork unitOfWork;
        public PrescriptionController()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

        #region Add Prescription Method
        public void AddPrescription(Patient p, string medicineName, string dose, DateTime prescriptionDate)
        {
            Prescription newPrescription = new Prescription(p, medicineName, dose, prescriptionDate);
            unitOfWork.PrescriptionRepository.Add(newPrescription);
            unitOfWork.Save();
            Console.WriteLine($"Prescription added successfully for {p.Name}");
        }
        #endregion
    }

}