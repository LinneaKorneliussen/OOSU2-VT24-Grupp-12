using Microsoft.VisualBasic;
using PatientDL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientBL
{
    public class AppointmentController
    {
        /// <summary>
        /// Controller class responsible for managing appointments and related operations.
        /// This class provides methods for retrieving patient information, available doctors information, booking appointments,
        /// managing existing appointments.  
        /// </summary>

        private AppointmentRepository appointmentRepository;
        public AppointmentController()
        {
            appointmentRepository = new AppointmentRepository();
        }

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return appointmentRepository.GetPatient(patientPersonalNumber); 
        }
        #endregion

        #region Book appointment Methods

        public void BookAppointment(Patient patient, DateTime dateAndTime, string reasonForVisit, Staff selectedDoctor)
        {
           appointmentRepository.BookAppointment(patient, dateAndTime, reasonForVisit, selectedDoctor);
        }
        #endregion

        #region Get doctors avilable Methods
        public List<Staff> GetAllAvailableDoctors(DateTime appointmentDateTime)
        {
            return appointmentRepository.GetAllAvailableDoctors(appointmentDateTime);
        }
        #endregion

        #region Manage existing appointment Methods
        public List<Appointment> GetAppointmentListPersonalNumber(Patient patient)
        {
            return appointmentRepository.GetAppointmentListPersonalNumber(patient);  
        }
        public void RemoveAppointment(Appointment appointmentToRemove)
        {
            appointmentRepository.RemoveAppointment(appointmentToRemove);   
        }
        public void UpdateDateTime(DateTime newDateTime, Appointment appointment)
        {
            appointmentRepository.UpdateDateTime(newDateTime, appointment); 
        }
        #endregion
    }
}
