using System;
using System.Collections.Generic;
using System.Linq;
using PatientEntities;
using PatientDL;

namespace PatientBL
{
    public class PatientMS
    {
        private PatientDL.UnitOfWork unitOfWork;
        public Staff LoggedIn
        {
            get; private set;
        }


        #region Log in Method
        public bool AuthorizeUser(int staffId, string password)
        {
            unitOfWork = new PatientDL.UnitOfWork();

            Staff VerifiedUser = unitOfWork.StaffRepository.FirstOrDefault(s => s.StaffId == staffId);

            if (VerifiedUser != null && VerifiedUser.GetHashedPassword(password) == VerifiedUser.PasswordHash)
            {
                LoggedIn = VerifiedUser;
                return true;
            }

            LoggedIn = null;
            return false;

        }
        #endregion

        #region Register new patient Method
        public void CreateNewPatient(string name, string personalNumber, string address, string phoneNumber, string emailAddress)
        {
            Patient patient = new Patient(name, personalNumber, address, phoneNumber, emailAddress);
            unitOfWork.PatientRepository.Add(patient);
            unitOfWork.Save();
        }
        #endregion

        #region Update patient information Method
        public void UpdatePatientInfo(Patient patientToUpdate, int choice, string newValue)
        {
            if (patientToUpdate != null)
            {
                switch (choice)
                {
                    case 1:
                        patientToUpdate.Name = newValue;
                        break;
                    case 2:
                        patientToUpdate.Address = newValue;
                        break;
                    case 3:
                        patientToUpdate.Phonenumber = newValue;
                        break;
                    case 4:
                        patientToUpdate.EmailAddress = newValue;
                        break;
                    default:
                        Console.WriteLine("Incorrect option, please try again!");
                        return;
                }

                Console.WriteLine($"{patientToUpdate.Name}'s information updated!");
            }
            else
            {
                Console.WriteLine($"Patient with personal number {patientToUpdate} not found.");
            }
        }

        #endregion

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
        public IList<Appointment> GetAppointmentListPersonalNumber(string personalnumber)
        {
            return unitOfWork.AppointmentRepository.GetAll().Where(appointment => appointment.Patient.PersonalNumber == personalnumber).ToList();
        }

        public void RemoveAppointment(Appointment appointmentToRemove)
        {
            bool evaluated = unitOfWork.AppointmentRepository.Remove(appointmentToRemove);
            unitOfWork.Save();

            if (evaluated == true)
            {
                Console.WriteLine("Appointment removed successfully");
            }
        }

        public Appointment GetAppointmentByVisitNumber(int visitNumber)
        {
            return unitOfWork.AppointmentRepository.FirstOrDefault(appointment => appointment.AppointmentId == visitNumber);
        }
        #endregion

        #region Add diagnosis Method
        public void AddDiagnosis(Patient p, string diagnosis, string treatmentplan)
        {
            Diagnosis newdiagnosis = new Diagnosis(p, diagnosis, treatmentplan);
            unitOfWork.DiagnosisRepository.Add(newdiagnosis);
            unitOfWork.Save();
            Console.WriteLine($"Diagnosis added successfully for {p.Name}");
        }
        #endregion

        #region Add Prescription Method
        public void AddPrescription(Patient p, string medicineName, string dose, DateTime prescriptionDate)
        {
            Prescription newPrescription = new Prescription(p, medicineName, dose, prescriptionDate);
            unitOfWork.PrescriptionRepository.Add(newPrescription);
            unitOfWork.Save();
            Console.WriteLine($"Prescription added successfully for {p.Name}");
        }
        #endregion

        #region Get appointment List Method
        public IList<Appointment> GetAppointmentList()
        {
            return unitOfWork.AppointmentRepository.GetAll().ToList();
        }
        #endregion
    }

}
