using System.Collections.Generic;
using System.Reflection.Metadata;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (LenghtValidator(password) == false)
                Console.WriteLine("Password must be between 6 and 10 characters");
            if (IsDigitOrLetter(password) == false)
                Console.WriteLine("Password must consist only of letters and digits");
            if (MinDigits(password) == false)
                Console.WriteLine("Password must have at least 2 digits");
            if (MinDigits(password) && IsDigitOrLetter(password) && LenghtValidator(password))
                Console.WriteLine("Password is valid");
        }

        static bool MinDigits(string password)
        {
            int digitC = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (digitC == 1)
                {
                    return true;
                }
                if (char.IsDigit(password[i]))
                {
                    digitC++;
                    continue;
                }
            }
            return false;
        }

        static bool IsDigitOrLetter(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetterOrDigit(password[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool LenghtValidator(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
                return true;
            else
                return false;
        }
    }
}