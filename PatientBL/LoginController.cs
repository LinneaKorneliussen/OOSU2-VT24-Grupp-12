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
        /// <summary>
        /// Controller class responsible for user authentication and authorization.
        /// </summary>

        private LogInRepository loginRepository;

        public LoginController()
        {
            loginRepository = new LogInRepository();
        }

        #region Log in Method
        public Staff AuthorizeUser(string username, string password)
        {
            return loginRepository.AuthorizeUser(username, password);
        }
        #endregion
    }
}
