using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PatientDL
{
    public class LogInRepository
    {
        /// <summary>
        /// Validates a user's login credentials and returns the user object. Otherwise it sets LoggidIn to null and returns null
        /// </summary>
        private UnitOfWork unitOfWork;

        public Staff LoggedIn
        {
            get; private set;
        }

        #region Log in Method
        public Staff AuthorizeUser(string username, string password)
        {
            unitOfWork = UnitOfWork.GetInstance();

            Doctor doctor = unitOfWork.DoctorRepository.FirstOrDefault(d => d.GenerateUsername() == username);
            if (doctor != null && doctor.GetHashedPassword(password) == doctor.PasswordHash)
            {
                LoggedIn = doctor;
                return doctor;
            }

            Nurse nurse = unitOfWork.NurseRepository.FirstOrDefault(n => n.GenerateUsername() == username);
            if (nurse != null && nurse.GetHashedPassword(password) == nurse.PasswordHash)
            {
                LoggedIn = nurse;
                return nurse;
            }

            LoggedIn = null;
            return null;
            

        }
        #endregion
    }
}
