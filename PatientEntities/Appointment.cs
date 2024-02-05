using System;

namespace PatientEntities
{
    public class Appointment 
    {
        private static int Count = 100;

        public int VisitNumber { get; private set; }

        public Patient Patient
        {
            get;
        }

        public DateTime DateAndTime
        {
            get; set;
        }

        public string ReasonForVisit
        {
            get; private set;
        }

        public Staff Doctor
        {
            get;
        }

        public Appointment(Patient patient, DateTime dateAndTime, string reason, Staff doctor)
        {
            Patient = patient;
            DateAndTime = dateAndTime;
            ReasonForVisit = reason;
            Doctor = doctor;
            VisitNumber = ++Count;

        }

        public void UpdateDateTime(DateTime newDateTime)
        {
            DateAndTime = newDateTime;
        }



    }
}
