using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientEntities
{
    public class Patient
    {
        private static int Count = 0;
        public int PatientNumber { get; private set; }
        public string Name
        {
            get; set;
        }
        public string PersonalNumber
        {
            get; private set;
        }
        public string Address
        {
            get; set;
        }

        public string Phonenumber
        {
            get; set;
        }

        public string EmailAddress
        {
            get; set;
        }

        public Patient(string name, string personalNumber, string address, string phonenumber, string emailAddress)
        {
            Name = name;
            PersonalNumber = personalNumber;
            Address = address;
            Phonenumber = phonenumber;
            EmailAddress = emailAddress;
            PatientNumber = ++Count;
        }

    }
}
