using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientEntities
{
    public class Diagnosis 
    {
        public Patient Patient
        {
            get;
        }

        public string DiagnosisDescription
        {
            get; private set;
        }

        public DateTime Date
        {
            get; private set;
        }

        public string Treatmentplan
        {
            get; private set;
        }

        public Diagnosis(Patient patient, string diagnosis, string treatmentplan)
        {
            Patient = patient;
            DiagnosisDescription = diagnosis;
            Date = DateTime.Now;
            Treatmentplan = treatmentplan;

        }
    }
}
