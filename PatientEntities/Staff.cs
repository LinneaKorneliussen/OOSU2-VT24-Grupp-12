using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PatientEntities
{
    public abstract class Staff
    {
        [Key]
        public int StaffId { get; init; }
        [Required]
        public string StaffName { get; private set; }
        [Required]
        public abstract string OccupationalRole { get; }
        [Required]
        public string PasswordHash { get; private set; }
        public string Specialization { get; private set; }
        public abstract string GenerateUsername();


        public Staff(string staffName, string password, string specialization)
        {
            StaffName = staffName;
            Specialization = specialization;
            PasswordHash = HashFunction(password);
        }
        public Staff() { }

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
