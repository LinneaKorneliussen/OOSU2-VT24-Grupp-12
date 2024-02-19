using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Staff AuthorizeUser(int staffId, string password)
        {
            unitOfWork = UnitOfWork.GetInstance();

            Staff VerifiedUser = unitOfWork.StaffRepository.FirstOrDefault(s => s.StaffId == staffId);

            if (VerifiedUser != null && VerifiedUser.GetHashedPassword(password) == VerifiedUser.PasswordHash)
            {
                LoggedIn = VerifiedUser;
                return VerifiedUser;
            }

            LoggedIn = null;
            return null;
        }
        #endregion
    }
}
