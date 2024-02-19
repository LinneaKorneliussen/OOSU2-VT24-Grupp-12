using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientEntities
{
    public class Prescription 
    {
        public int PrescriptionId { get; init; }
        [Column("Medicine name")]
        public string MedicineName { get; private set; }
        public string Dose { get; private set;}
        public DateTime Date { get; private set; }
        [Required]
        public Patient Patient { get; private set; }

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
