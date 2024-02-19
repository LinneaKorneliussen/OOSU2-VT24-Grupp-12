using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientEntities
{
    public class Appointment 
    {
        public int AppointmentId { get; init; }
        public DateTime DateAndTime { get; set; }
        public TimeSpan Duration { get; } = TimeSpan.FromMinutes(45);
        public DateTime EndDateTime => DateAndTime.Add(Duration);
        [Column("Reason for visit")]
        public string ReasonForVisit { get; private set; }
        [Required]
        public Staff Doctor {  get; private set; }
        [Required]
        public Patient Patient { get; private set; }

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
