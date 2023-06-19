using System;
using System.Text.RegularExpressions;

namespace UC_10
{
    public class StringValidator
    {
        private const string SPECIAL_CHARS = "!\"#\\$%&'\\(\\)\\*\\+,-\\./:;<=>\\?@\\[\\\\\\]\\^_`\\{\\|\\}~";

        /// <summary>
        /// Validate a string with a maximum length to make sure it has a lowercase letter, an uppercase letter,
        /// a digit, a special character, no whitespace, and fits within a specified maximum length
        /// </summary>
        /// <param name="value">String to be validated</param>
        /// <param name="maxLength">Maximum length</param>
        /// <returns>true if validation is successful, otherwise false</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool Validate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value");
            }
            if (maxLength <= 0)
            {
                throw new ArgumentOutOfRangeException("The maxLength should be positive");
            }

            string regexp = $"^(?=.*\\d)" + // At least one digit
                $"(?=.*[a-z])" + // At least one lowercase letter
                $"(?=.*[A-Z])" + // At least one uppercase letter
                $"(?=.*[{SPECIAL_CHARS}])" + // At least one special character
                $"\\S" + // No whitespace
                $"{{1,{maxLength}}}$"; // Length validation

            return Regex.IsMatch(value, regexp);
        }
    }
}
