using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PatientEntities
{
    public class Staff
    {
        public int EmployeeNumber
        {
            get; private set;
        }

        public string StaffName
        {
            get; private set;
        }
        public string OccupationalRole
        {
            get; private set;
        }
        public string PasswordHash
        {
            get; private set;
        }
        public string Specialization
        {
            get; private set;
        }

        public Staff(int employeeNumber, string staffName, string occupationalRole, string password, string specialization)
        {
            EmployeeNumber = employeeNumber;
            StaffName = staffName;
            OccupationalRole = occupationalRole;
            Specialization = specialization;
            PasswordHash = HashFunction(password);
        }

        public string GetHashedPassword(string password)
        {
            return HashFunction(password);
        }

        public string HashFunction(string input)
        {
            return ComputeSHA256Hash(input);
        }

        private string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).ToLower().Replace("-", String.Empty);
            }
        }
    }
}
