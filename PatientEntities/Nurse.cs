using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatientEntities
{
    [Table("Nurses")]
    public class Nurse : Staff
    {
        public override string OccupationalRole => "Nurse";
        public Nurse (string staffName, string password, string specialization)
            : base(staffName, password, specialization) {}

        public Nurse() { }

        public override string GenerateUsername()
        {
            string username = $"{StaffId}{StaffName.Split(' ')[0].Substring(0, 1)}{StaffName.Split(' ')[1]}_Nur";
            return username;
        }
    }
}
