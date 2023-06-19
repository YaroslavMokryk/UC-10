namespace UC_10
{
    public class StringValidatorTests
    {
        /// <summary>
        /// Tests StringValidator functionality and outputs results to console
        /// </summary>
        public static void TestStringValidator()
        {
            bool throwsArgumentNullException = Test_NullString_ThrowsArgumentNullException();
            Console.WriteLine($"Test_NullString_ThrowsArgumentNullException: {throwsArgumentNullException}");
            bool throwsArgumentOutOfRangeException = Test_InvalidMaxLength_ThrowsArgumentOutOfRangeException();
            Console.WriteLine($"Test_InvalidMaxLength_ThrowsArgumentOutOfRangeException: {throwsArgumentOutOfRangeException}");
            bool lengthValidation = Test_LengthValidation();
            Console.WriteLine($"Test_LengthValidation: {lengthValidation}");
            bool uppercaseValidation = Test_UppercaseValidation();
            Console.WriteLine($"Test_UppercaseValidation: {uppercaseValidation}");
            bool lowercaseValidation = Test_LowercaseValidation();
            Console.WriteLine($"Test_LowercaseValidation: {lowercaseValidation}");
            bool specialCharacterValidation = Test_SpecialCharacterValidation();
            Console.WriteLine($"Test_SpecialCharacterValidation: {specialCharacterValidation}");
            bool digitValidation = Test_DigitValidation();
            Console.WriteLine($"Test_DigitValidation: {digitValidation}");
            bool whitespaceValidation = Test_WhitespaceValidation();
            Console.WriteLine($"Test_WhitespaceValidation: {whitespaceValidation}");
        }

        private static bool Test_NullString_ThrowsArgumentNullException()
        {
            try
            {
                StringValidator.Validate(string.Empty, 1);
            }
            catch(ArgumentNullException e)
            {
                return true;
            }
            return false;
        }

        private static bool Test_InvalidMaxLength_ThrowsArgumentOutOfRangeException()
        {
            try
            {
                StringValidator.Validate("Test1!", 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return true;
            }
            return false;
        }

        private static bool Test_LengthValidation()
        {
            bool badResult = StringValidator.Validate("Test1!", 5);
            bool goodResult = StringValidator.Validate("Test1!", 6);

            return !badResult && goodResult;
        }

        private static bool Test_UppercaseValidation()
        {
            bool badResult = StringValidator.Validate("test1!", 10);
            bool goodResult = StringValidator.Validate("Test1!", 10);

            return !badResult && goodResult;
        }

        private static bool Test_LowercaseValidation()
        {
            bool badResult = StringValidator.Validate("TEST1!", 10);
            bool goodResult = StringValidator.Validate("Test1!", 10);

            return !badResult && goodResult;
        }

        private static bool Test_SpecialCharacterValidation()
        {
            bool badResult = StringValidator.Validate("Test1", 10);
            bool goodResult = StringValidator.Validate("Test1!", 10);

            return !badResult && goodResult;
        }

        private static bool Test_DigitValidation()
        {
            bool badResult = StringValidator.Validate("Test!", 10);
            bool goodResult = StringValidator.Validate("Test1!", 10);

            return !badResult && goodResult;
        }

        private static bool Test_WhitespaceValidation()
        {
            bool badResultSpace = StringValidator.Validate("Test 1!", 10);
            bool badResultTab = StringValidator.Validate("\tTest1!", 10);
            bool badResultEndline = StringValidator.Validate("Test\n1!", 10);
            bool goodResult = StringValidator.Validate("Test1!", 10);

            return !badResultSpace && !badResultTab && !badResultEndline && goodResult;
        }
    }
}
