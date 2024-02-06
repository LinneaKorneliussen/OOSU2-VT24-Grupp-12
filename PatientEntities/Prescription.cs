using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientEntities
{
    public class Prescription 
    {
        public int PrescriptionId { get; set; }
        public string MedicineName { get; set; }
        public string Dose { get; set;}
        public DateTime Date { get; set; }
        public Patient Patient { get; set; }

        public Prescription(Patient patient, string medicineName, string dose, DateTime prescriptionDate)
        {
            Patient = patient;
            MedicineName = medicineName;
            Dose = dose;
            Date = prescriptionDate;
        }
        public Prescription() { }
    }
}
