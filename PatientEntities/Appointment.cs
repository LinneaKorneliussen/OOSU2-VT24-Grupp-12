using System;
using System.ComponentModel.DataAnnotations;

namespace PatientEntities
{
    public class Appointment 
    {
        public int AppointmentId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string ReasonForVisit { get; set; }
        public Staff Doctor {  get; set; }
        public Patient Patient { get; set; }

        public Appointment(Patient patient, DateTime dateAndTime, string reason, Staff doctor)
        {
            Patient = patient;
            DateAndTime = dateAndTime;
            ReasonForVisit = reason;
            Doctor = doctor;
        }

        public Appointment() { }

        public void UpdateDateTime(DateTime newDateTime)
        {
            DateAndTime = newDateTime;
        }
    }
}
