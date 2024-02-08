using System;
using System.ComponentModel.DataAnnotations;

namespace PatientEntities
{
    public class Appointment 
    {
        public int AppointmentId { get; set; }
        public DateTime DateAndTime { get; set; }
        public TimeSpan Duration { get; } = TimeSpan.FromMinutes(45);
        public DateTime EndDateTime => DateAndTime.Add(Duration); 
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
    }
}
