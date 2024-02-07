using PatientDL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientBL
{
    public class LoginController
    {
        private UnitOfWork unitOfWork;

        public Staff LoggedIn
        {
            get; private set;
        }

        #region Log in Method
        public bool AuthorizeUser(int staffId, string password)
        {
            unitOfWork = UnitOfWork.GetInstance();

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
    }
}
