using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientEntities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string PersonalNumber { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
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
