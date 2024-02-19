using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDL
{
    public class AppointmentRepository
    {
        /// <summary>
        /// This repository class serves as the intermediary layer between the application's business logic 
        /// and the data storage, facilitating operations pertaining to appointments and associated entities. 
        /// It encapsulates data access logic, providing methods for retrieving patient information, booking 
        /// appointments, managing existing appointments, and doctor availability.
        /// </summary>
       
        private UnitOfWork unitOfWork;
        public AppointmentRepository()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return unitOfWork.PatientRepository.FirstOrDefault(p => p.PersonalNumber == patientPersonalNumber);
        }
        #endregion

        #region Book appointment and get doctors Methods
        public void BookAppointment(Patient patient, DateTime dateAndTime, string reasonForVisit, Staff selectedDoctor)
        {
            if (selectedDoctor != null)
            {
                Appointment appointment = new Appointment(patient, dateAndTime, reasonForVisit, selectedDoctor);

                unitOfWork.AppointmentRepository.Add(appointment);
                unitOfWork.Save();
            }
        }

        public List<Staff> GetAllDoctors()
        {
            return unitOfWork.StaffRepository.Find(s => s.OccupationalRole == "Doctor").ToList();
        }

        public List<Appointment> GetAppointmentsForDateTime(DateTime appointmentDateTime)
        {
            List<Appointment> appointments = unitOfWork.AppointmentRepository.Find(a => (a.DateAndTime <= appointmentDateTime && appointmentDateTime < a.EndDateTime) ||
            (a.DateAndTime < appointmentDateTime && a.EndDateTime >= appointmentDateTime)).ToList();

            return appointments;
        }

        public List<Staff> GetAllAvailableDoctors(DateTime appointmentDateTime)
        {
            List<Staff> allDoctors = GetAllDoctors();
            List<Appointment> appointments = GetAppointmentsForDateTime(appointmentDateTime);

            List<Staff> availableDoctors = allDoctors.Where(doctor =>
                !appointments.Any(appointment => appointment.Doctor.StaffId == doctor.StaffId)).ToList();

            return availableDoctors;
        }
        #endregion

        #region Manage existing appointments Methods 
        public List<Appointment> GetAppointmentListPersonalNumber(Patient patient)
        {
            return unitOfWork.AppointmentRepository.GetAll().Where(appointment => appointment.Patient.PersonalNumber == patient.PersonalNumber).ToList();
        }
        public void RemoveAppointment(Appointment appointmentToRemove)
        {
            unitOfWork.AppointmentRepository.Remove(appointmentToRemove);
            unitOfWork.Save();
        }
        public void UpdateDateTime(DateTime newDateTime, Appointment appointment)
        {
            appointment.DateAndTime = newDateTime;
            unitOfWork.Save();
        }
        #endregion
    }
}
