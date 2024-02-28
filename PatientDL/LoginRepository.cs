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

            Doctor verifiedDoctor = unitOfWork.DoctorRepository.FirstOrDefault(d => d.GenerateUsername() == username);
            if (verifiedDoctor != null && verifiedDoctor.GetHashedPassword(password) == verifiedDoctor.PasswordHash)
            {
                LoggedIn = verifiedDoctor;
                return verifiedDoctor;
            }

            Nurse verifiedNurse = unitOfWork.NurseRepository.FirstOrDefault(n => n.GenerateUsername() == username);
            if (verifiedNurse != null && verifiedNurse.GetHashedPassword(password) == verifiedNurse.PasswordHash)
            {
                LoggedIn = verifiedNurse;
                return verifiedNurse;
            }

            LoggedIn = null;
            return null;
            

        }
        #endregion
    }
}
