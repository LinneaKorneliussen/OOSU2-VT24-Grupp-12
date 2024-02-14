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
        private LogInRepository loginRepository;

        public LoginController()
        {
            loginRepository = new LogInRepository();
        }

        #region Log in Method
        public Staff AuthorizeUser(int staffId, string password)
        {
            return loginRepository.AuthorizeUser(staffId, password);
        }
        #endregion
    }
}
