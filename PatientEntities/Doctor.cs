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
        public override string OccupationalRole => "Doctor";
        public ICollection<Appointment> appointments { get; set; }


        public Doctor(string staffName, string password, string specialization)
            : base(staffName, password, specialization)
        {
   
        }
        public Doctor() { }

        public override string GenerateUsername()
        {
            string username = $"{StaffId}{StaffName.Split(' ')[0].Substring(0, 1)}{StaffName.Split(' ')[1]}_Doc";
            return username;
        }
    }

    
}
