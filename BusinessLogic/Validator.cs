using System;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            ssn = ssn.Trim();
            ssn.Replace("-", "");
            //If number does not have a length of 9 or have anything other than digits
            if (ssn.Length != 9 || !System.Text.RegularExpressions.Regex.IsMatch(ssn, "[0-9]*"))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            if (numToTest < minValue || numToTest > maxValue)
            {
                return false;
            }
            return true;
        }
    }
}
