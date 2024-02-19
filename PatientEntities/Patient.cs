using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientEntities
{
    public class Patient
    {
        public int PatientId { get; init; }
        [Column("Personal number")]
        [Required]
        public string PersonalNumber { get; private set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phonenumber { get; set; }
        [Column("Email address")]
        public string EmailAddress { get; set; }
        public ICollection<Diagnosis> Diagnosis { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

        public Patient(string name, string personalNumber, string address, string phonenumber, string emailAddress)
        {
            Name = name;
            PersonalNumber = personalNumber;
            Address = address;
            Phonenumber = phonenumber;
            EmailAddress = emailAddress;
        }
        public Patient() { }

    }
}
