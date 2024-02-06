using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientEntities
{
    public class Diagnosis 
    {
        public int DiagnosisId { get; set; }
        public string DiagnosisDescription { get; set;}
        public DateTime Date { get;  set; }
        public string Treatmentplan { get; set;}
        public Patient Patient { get; set; }

        public Diagnosis(Patient patient, string diagnosis, string treatmentplan)
        {
            Patient = patient;
            DiagnosisDescription = diagnosis;
            Date = DateTime.Now;
            Treatmentplan = treatmentplan;

        }
        public Diagnosis() { }
    }
}
