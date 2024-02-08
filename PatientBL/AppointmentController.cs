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
        private UnitOfWork unitOfWork;
        public AppointmentController()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

        #region Book appointment Methods
        public void BookAppointment(Patient patient, DateTime dateAndTime, string reasonForVisit, Staff selectedDoctor)
        {
            if (selectedDoctor != null)
            {
                Appointment appointment = new Appointment(patient, dateAndTime, reasonForVisit, selectedDoctor);

                unitOfWork.AppointmentRepository.Add(appointment);
                unitOfWork.Save();

                Console.WriteLine($"\nAppointment booked for {patient.Name} on {dateAndTime.ToString()} Reason: {reasonForVisit}. Doctor: {selectedDoctor.StaffName} Patientnumber: {patient.PatientId}.\n");
            }
            else
            {
                Console.WriteLine("No doctor selected.");
            }

        }
        #endregion

        #region Get patients and doctors Methods
        public Patient GetPatient(string patientPersonalNumber)
        {
            return unitOfWork.PatientRepository.FirstOrDefault(p => p.PersonalNumber == patientPersonalNumber);
        }
        public List<Staff> GetAllDoctors()
        {
            return unitOfWork.StaffRepository.Find(s => s.OccupationalRole == "Doctor").ToList();
        }
        public List<Appointment> GetAppointmentsForDateTime(DateTime appointmentDateTime)
        {
            return unitOfWork.AppointmentRepository.Find(a => a.DateAndTime == appointmentDateTime).ToList();
        }
        public List<Staff> GetAllAvailableDoctors(DateTime appointmentDateTime)
        {
            List<Staff> allDoctors = unitOfWork.StaffRepository.Find(s => s.OccupationalRole == "Doctor").ToList();
            List<Appointment> appointments = GetAppointmentsForDateTime(appointmentDateTime);
            List<Staff> availableDoctors = allDoctors.Where(doctor =>
                !appointments.Any(appointment => appointment.Doctor.StaffId == doctor.StaffId)
            ).ToList();

            return availableDoctors;
        }
        #endregion

        #region Select doctor Method
        public Staff SelectDoctor(List<Staff> availableDoctors)
        {
            if (availableDoctors.Count > 0)
            {
                int doctorIndex;
                do
                {
                    Console.Write("Select doctor: ");
                } while (!int.TryParse(Console.ReadLine(), out doctorIndex) || doctorIndex < 1 || doctorIndex > availableDoctors.Count);

                return availableDoctors[doctorIndex - 1];
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Manage existing appointment Methods
        public List<Appointment> GetAppointmentListPersonalNumber(string personalnumber)
        {
            return unitOfWork.AppointmentRepository.GetAll().Where(appointment => appointment.Patient.PersonalNumber == personalnumber).ToList();
        }

        public void RemoveAppointment(Appointment appointmentToRemove)
        {
            unitOfWork.AppointmentRepository.Remove(appointmentToRemove);
            unitOfWork.Save();

        }

        public Appointment GetAppointmentByVisitNumber(int visitNumber)
        {
            return unitOfWork.AppointmentRepository.FirstOrDefault(appointment => appointment.AppointmentId == visitNumber);
        }

        public void UpdateDateTime(DateTime newDateTime, Appointment appointment)
        {
            appointment.DateAndTime = newDateTime;
            unitOfWork.Save();
        }
        #endregion
    }
}
