using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional_assignment1
{
    public class Assignment1
    {
        public static string Formatter(string firstName, string lastName)
        {
            string formattedFirstName = (firstName[0].ToString().ToUpper()) + firstName.Substring(1).ToLower();
            string formattedLastName = (lastName[0].ToString().ToUpper()) + lastName.Substring(1).ToLower();
            string initials = $"{lastName.Substring(0,3).ToUpper()}{firstName.Substring(0,3).ToUpper()}";
            string result = $"#_{formattedLastName},{formattedFirstName}({initials})";
            return result;
        }
    }
}
