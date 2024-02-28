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
        //[Key]
        //public int NurseId { get; init; }
        
        public Nurse (string staffName, string occupationalRole, string password, string specialization)
            : base(staffName, occupationalRole, password, specialization) {}

        public Nurse() { }
    }
}
