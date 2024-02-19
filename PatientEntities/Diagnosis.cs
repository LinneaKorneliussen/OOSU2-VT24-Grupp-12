using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientEntities
{
    public class Diagnosis 
    {
        public int DiagnosisId { get; init; }
        [Column("Diagnosis description")]
        public string DiagnosisDescription { get; private set;}
        public DateTime Date { get;  private set; }
        public string Treatmentplan { get; private set;}
        [Required]
        public Patient Patient { get; private set; }

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
