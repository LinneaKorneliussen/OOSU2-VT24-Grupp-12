using System;
using PatientBL;
using PatientEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PatientUIConsole
{
    //Grupp 12 Linnea Korneliussen, Beata Jacobsson, Clara Hansson, Celina Linnerblom Persson 
    // hejjddååå
    internal class Program
    {

        private PatientMS patientMS;
        private bool isLoggedIn = false;

        static void Main(string[] args)
        {
            new Program().Main();
        }
        private Program()
        {
            patientMS = new PatientMS();
        }

        #region Main log in Method
        /// <summary>
        /// Manages user authentication and handles potential errors through exception handling
        /// </summary>
        private void Main()
        {
            Console.WriteLine("Welcome to Patient Managing System\n");

            while (true)
            {
                try
                {
                    if (!isLoggedIn)
                    {
                        if (LogIn())
                        {
                            Console.WriteLine($"\nYou are logged in as Caregiver: {patientMS.LoggedIn.OccupationalRole} {patientMS.LoggedIn.StaffName}\n");
                            isLoggedIn = true;
                        }
                        else
                        {
                            Console.WriteLine("Failed to log in.\n");
                            continue;
                        }
                    }

                    MainMenu();
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }

        }
        #endregion

        #region LogIn Method
        /// <summary>
        /// Returns an employee based on employee number
        /// Validation of user integer input
        /// </summary>
        /// <returns></returns>
        private bool LogIn()
        {
            Console.Write("Enter Employee Number: ");
            int EmployeeNumber = Validation.ValidatePositiveIntegerInput(Console.ReadLine());

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            return patientMS.AuthorizeUser(EmployeeNumber, password);
        }
        #endregion

        #region Main menu Method
        /// <summary>
        /// Menu display and handles options through a switch case
        /// Validation of user integer input
        /// </summary>
        private void MainMenu()
        {
            Console.WriteLine("\nMain menu:");
            Console.WriteLine("1.Register new patient\n" +
                "2.Update patient information\n" +
                "3.Book new appointment\n" +
                "4.Manage existing appointment\n" +
                "5.Register new diagnosis\n" +
                "6.Register new prescription\n" +
                "7.Display upcoming appointments\n" +
                "8.Log off\n");
            Console.Write("Select option: ");

            int menuOption = Validation.ValidatePositiveIntegerInput(Console.ReadLine());

            switch (menuOption)
            {
                case 1:
                    CreateNewPatient();
                    break;
                case 2:
                    UpdatePatientInfo();
                    break;
                case 3:
                    BookNewAppointment();
                    break;
                case 4:
                    ManageAppointments();
                    break;
                case 5:
                    SetDiagnosis();
                    break;
                case 6:
                    SetPrescription();
                    break;
                case 7:
                    DisplayFutureAppointments();
                    break;
                case 8:
                    Environment.Exit(8);
                    break;

            }

        }
        #endregion

        #region Create new patient Method
        /// <summary>
        /// Handles user input
        /// Validation of personal number
        /// </summary>
        private void CreateNewPatient()
        {
            string Name;
            string PersonalNumber;
            string Address;
            string Phonenumber;
            string EmailAddress;

            Console.WriteLine("Provide following information");
            Console.Write($"Name: ");
            Name = Console.ReadLine();
            do
            {
                Console.Write($"Personal number (yyyy-mm-dd-xxxx): ");
                PersonalNumber = Console.ReadLine();
            } while (!Validation.ValidatePersonalNumber(PersonalNumber));

            Console.Write($"Address: ");
            Address = Console.ReadLine();
            Console.Write($"Phonenumber: ");
            Phonenumber = Console.ReadLine();
            Console.Write($"Emailaddress: ");
            EmailAddress = Console.ReadLine();

            patientMS.CreateNewPatient(Name, PersonalNumber, Address, Phonenumber, EmailAddress);
        }
        #endregion

        #region Update patient information Method
        /// <summary>
        /// Get patient through personal number
        /// New value, option and patient sends as argument to bussiness layer for updating the choosen information
        /// </summary>
        private void UpdatePatientInfo()
        {
            Patient patientToUpdate = GetPatientByPersonalNumber();

            if (patientToUpdate != null)
            {
                Console.WriteLine($"Current information for {patientToUpdate.PersonalNumber}:");
                Console.WriteLine($"1. Name: {patientToUpdate.Name}");
                Console.WriteLine($"2. Address: {patientToUpdate.Address}");
                Console.WriteLine($"3. Phonenumber: {patientToUpdate.Phonenumber}");
                Console.WriteLine($"4. Emailaddress: {patientToUpdate.EmailAddress}");

                int numberOfOptions = 4;
                int choice;
                do
                {
                    Console.Write("Select option: ");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        if (choice < 1 || choice > numberOfOptions)
                        {
                            Console.WriteLine($"Invalid option. Please enter a number between 1 and {numberOfOptions}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please enter a valid number.");
                    }
                } while (choice < 1 || choice > numberOfOptions);

                Console.Write($"Provide new value for option {choice}: ");
                string newValue = Console.ReadLine();

                patientMS.UpdatePatientInfo(patientToUpdate, choice, newValue);
            }
        }

        #endregion

        #region Book new appointment Method
        /// <summary>
        ///  Get patient through personal number
        ///  Validation of date time input
        ///  Get and select doctor methods from business layer
        /// </summary>
        private void BookNewAppointment()
        {
            Patient patient = GetPatientByPersonalNumber();

            if (patient != null)
            {
                Console.Write("Enter appointment date (yyyy-MM-dd 00:00): ");
                DateTime dateAndTime = Validation.ValidateDateTimeInput(Console.ReadLine());

                Console.Write("Enter reason for visit: ");
                string reasonForVisit = Console.ReadLine();

                List<Staff> availableDoctors = patientMS.GetAllDoctors();
                DisplayAvailableDoctors(availableDoctors);

                if (availableDoctors.Count > 0)
                {
                    Staff selectedDoctor = patientMS.SelectDoctor(availableDoctors);

                    patientMS.BookAppointment(patient, dateAndTime, reasonForVisit, selectedDoctor);
                }
                else
                {
                    Console.WriteLine("No available doctors.");
                }
            }
            else
            {
                Console.WriteLine("Appointment booking canceled.\n");
            }
        }
        #endregion

        #region Display available doctors Method
        /// <summary>
        /// Get available doctors and displays
        /// </summary>
        /// <param name="availableDoctors"></param>
        private void DisplayAvailableDoctors(List<Staff> availableDoctors)
        {
            Console.WriteLine(new string('_', 75));
            Console.WriteLine("{0,-5} {1,-10} {2,-25} {3,-25}", "Index", "Title", "Name", "Specialization");
            Console.WriteLine(new string('_', 75));

            for (int i = 0; i < availableDoctors.Count; i++)
            {
                Console.WriteLine($"{i + 1,-5} {((Staff)(object)availableDoctors[i]).OccupationalRole,-10}" +
                $" {((Staff)(object)availableDoctors[i]).StaffName,-25} {((Staff)(object)availableDoctors[i]).Specialization,-25}");
            }

        }
        #endregion

        #region Manage existing appointment Method
        /// <summary>
        /// Get patient through personal number
        /// Validation of integer and date time input
        /// Shows all appointment through personal number 
        /// Switch case update date time information or remove appointment. Get appointment by visit number
        /// </summary></param>
        private void ManageAppointments()
        {
            Patient patientToUpdate = GetPatientByPersonalNumber();

            if (patientToUpdate != null)
            {
                Console.WriteLine("Patient's Appointments:");
                ShowAllAppointments(patientToUpdate.PersonalNumber);
                Console.WriteLine("\nChoose what to do:");
                Console.WriteLine("1. Update appointment date and time");
                Console.WriteLine("2. Remove appointment");
                Console.Write("Select option: ");

                if (int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    switch (userChoice)
                    {
                        case 1:
                            Console.Write("Enter visit number for the appointment to update: ");
                            int visitNumber = Validation.ValidatePositiveIntegerInput(Console.ReadLine());

                            Appointment appointmentToUpdate = patientMS.GetAppointmentByVisitNumber(visitNumber);

                            if (appointmentToUpdate != null)
                            {
                                Console.Write("Enter new date and time (yyyy-MM-dd HH:mm): ");
                                DateTime newDateTime = Validation.ValidateDateTimeInput(Console.ReadLine());

                                appointmentToUpdate.UpdateDateTime(newDateTime);
                                Console.WriteLine("Appointment date and time updated!");
                            }
                            else
                            {
                                Console.WriteLine($"Appointment with visit number {visitNumber} not found.");
                            }
                            break;
                        case 2:
                            Console.Write("Enter visit number for the appointment to remove: ");
                            int visitNumberToRemove = Validation.ValidatePositiveIntegerInput(Console.ReadLine());
                            RemoveAppointment(visitNumberToRemove);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        public void RemoveAppointment(int visitNumber)
        {
            Appointment appointmentToRemove = patientMS.GetAppointmentByVisitNumber(visitNumber);

            if (appointmentToRemove != null)
            {
                patientMS.RemoveAppointment(appointmentToRemove);
            }
            else
            {
                Console.WriteLine($"Appointment with visit number {visitNumber} not found.");
            }
        }

        public void ShowAllAppointments(string personalNumber)
        {
            IList<Appointment> appointments = patientMS.GetAppointmentListPersonalNumber(personalNumber);

            if (appointments.Any())
            {
                Console.WriteLine($"All appointments for patient with personal number {personalNumber}:");
                foreach (var appointment in appointments)
                {
                    Console.WriteLine($"Visit Number: {appointment.VisitNumber}");
                    Console.WriteLine($"DateAndTime and Time: {appointment.DateAndTime.ToString("yyyy-MM-dd HH:mm")}");
                    Console.WriteLine($"Reason for Visit: {appointment.ReasonForVisit}");
                }
            }
            else
            {
                Console.WriteLine($"No appointments found for patient with personal number {personalNumber}.");
            }
        }

        #endregion

        #region Register diagnosis Method
        /// <summary>
        /// Get patient through personal number
        /// Get user input and sends as arguments to bussines layer 
        /// </summary>
        private void SetDiagnosis()
        {
            Patient setDiagnos = GetPatientByPersonalNumber();
            if (setDiagnos != null)
            {
                Console.Write("Enter diagnosis description: ");
                string diagnosisInfo = Console.ReadLine();
                Console.Write("Enter treatmentplan: ");
                string treatmentplanInfo = Console.ReadLine();

                patientMS.AddDiagnosis(setDiagnos, diagnosisInfo, treatmentplanInfo);
            }
        }
        #endregion

        #region Register prescription Method
        /// <summary>
        /// Get patient through personal number
        /// Get user input and sends as arguments to bussines layer 
        /// Validation of date time input 
        /// </summary>
        private void SetPrescription()
        {
            Patient setPrescription = GetPatientByPersonalNumber();
            if (setPrescription != null)
            {
                Console.Write("Enter medicine name: ");
                string medicineName = Console.ReadLine();
                Console.Write("Enter dose: ");
                string doseInfo = Console.ReadLine();
                Console.Write("Enter prescriptiondate (yyyy-MM-DD HH:MM): ");
                DateTime presciptionDate = Validation.ValidateDateTimeInput(Console.ReadLine());

                patientMS.AddPrescription(setPrescription, doseInfo, medicineName, presciptionDate);
            }
        }

        #endregion

        #region Future Appoinments Method
        /// <summary>
        /// Get patient through personal number
        /// Get appointment list from bussines layer
        /// Filters and orders future appointments with LINQ query and presents the details in a formatted table
        /// </summary>
        public void DisplayFutureAppointments()
        {
            Patient patient = GetPatientByPersonalNumber();
            IList<Appointment> FutureAppointments = patientMS.GetAppointmentList();
            var result = from x in FutureAppointments
                         where x.Patient.PersonalNumber.Equals(patient.PersonalNumber) &&
                         x.DateAndTime > DateTime.Now.Date
                         orderby x.DateAndTime ascending
                         select x;

            Console.WriteLine("Future Appointments:");

            if (result.Any())
            {
                Console.WriteLine($"All appointments for {result.First().Patient.Name}");
                Console.WriteLine(new string('_', 125));
                Console.WriteLine("{0,-25} {1,-20} {2,-15} {3,-25} {4,-20} {5,-10}", "Patient", "DateAndTime", "Time", "Reason", "Doctor", "Visitnumber");
                Console.WriteLine(new string('_', 125));
            }

            foreach (Appointment a in result)
            {
                Console.WriteLine("{0,-25} {1,-20} {2,-15} {3,-25} {4,-20} {5,-10}", a.Patient.Name, a.DateAndTime.ToShortDateString(), a.DateAndTime.ToShortTimeString(), a.ReasonForVisit, a.Doctor.StaffName, a.VisitNumber);
            }


        }
        #endregion

        #region Get Patient by personalnumber Method
        /// <summary>
        /// Returns a patient based on personalnumber
        /// Validation of personal number
        /// </summary>
        /// <returns>the patient.</returns>
        private Patient GetPatientByPersonalNumber()
        {
            string patientPersonalNumber;

            do
            {
                Console.Write($"Personal number (yyyy-mm-dd-xxxx): ");
                patientPersonalNumber = Console.ReadLine();
            } while (!Validation.ValidatePersonalNumber(patientPersonalNumber));

            Patient patient = patientMS.GetPatient(patientPersonalNumber);

            if (patient == null)
            {
                Console.WriteLine($"Patient with personal number {patientPersonalNumber} not found.");
            }
            else
            {
                Console.WriteLine($"Patient found: {patient.Name}");
            }

            return patient;
        }
        #endregion
    }
}

   

    
