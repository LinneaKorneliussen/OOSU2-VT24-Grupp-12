using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatientEntities
{
    [Table ("Doctors")]
    public class Doctor : Staff
    {
        //[Key]
        //public int DoctorId { get; init; }
        public int YearsOfExperience {  get; set; }

        public ICollection<Appointment> appointments { get; set; }

        public Doctor(string staffName, string occupationalRole, string password, string specialization, int yearsOfExperience)
            : base(staffName, occupationalRole, password, specialization)
        {
            this.YearsOfExperience = yearsOfExperience;
        }
        public Doctor() { } 

    }

    
}
