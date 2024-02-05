using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PatientBL
{
    public class Validation
    {
        #region Validation Methods
        public static DateTime ValidateDateTimeInput(string input)
        {
            DateTime result;
            while (!DateTime.TryParseExact(input, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                Console.Write("Incorrect format, please enter a valid date and time (yyyy-MM-dd HH:mm): ");
                input = Console.ReadLine();
            }
            return result;
        }

        public static int ValidatePositiveIntegerInput(string input)
        {
            int result;
            while (!int.TryParse(input, out result) || result <= 0)
            {
                Console.Write("Invalid input, please enter a valid positive integer: ");
                input = Console.ReadLine();
            }
            return result;
        }

        public static bool ValidatePersonalNumber(string input)
        {
            string pattern = @"^\d{4}-\d{2}-\d{2}-\d{4}$";

            Regex regex = new Regex(pattern);

            bool isValid = regex.IsMatch(input);

            if (!isValid)
            {
                Console.Write($"Incorrect format, ");
            }

            return isValid;
        }
        #endregion


    }
}
