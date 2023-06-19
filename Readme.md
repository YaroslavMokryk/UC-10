UC#10 .NET Repository

# Description
This project contains a StringValidator for validating string input according to some specifications. When running the application, it calls a few test methods to test the functionality of the validator with different input strings and max length parameters. There is also a maximum length paramter to specify the maximum allowed length of the input string.
# Regex Implementation
The regular expression matches the input string with the following criteria:
- This regular expression validates the maximum string length (passed as parameter); it should return a match if the string length is within the acceptable range and a non-match if it is not.
- This regular expression also validates that the string contains at least one uppercase letter, one lowercase letter, one digit, and one special character from a predefined list: !"#$%&'()*+,-./:;<=>?@[\]^_`{|}~. It should return a match if the criteria are met and a non-match if they are not.
- This regular expression validates that the string does not contain any whitespace characters (spaces, tabs, or newlines). This should return a non-match if any whitespace characters are found.
# How to run
The application can be run from the main entry point by building and running it with Visual Studio or by simply running the UC-10\bin\Debug\net6.0\UC-10.exe executable. This will run the automated tests to ensure the validator is functioning correctly.
