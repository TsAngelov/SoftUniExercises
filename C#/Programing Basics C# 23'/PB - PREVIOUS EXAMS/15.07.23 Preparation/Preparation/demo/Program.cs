using System;

class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        int validChangesCount = 0;

        for (int firstDigit1 = K; firstDigit1 <= 8; firstDigit1++)
        {
            for (int secondDigit1 = 9; secondDigit1 <= L; secondDigit1++)
            {
                for (int firstDigit2 = M; firstDigit2 <= 8; firstDigit2++)
                {
                    for (int secondDigit2 = 9; secondDigit2 <= N; secondDigit2++)
                    {
                        bool isFirstNumberValid = IsNumberValid(firstDigit1, secondDigit1);
                        bool isSecondNumberValid = IsNumberValid(firstDigit2, secondDigit2);
                        bool areNumbersEqual = firstDigit1 == firstDigit2 && secondDigit1 == secondDigit2;

                        if (isFirstNumberValid && isSecondNumberValid && !areNumbersEqual)
                        {
                            Console.WriteLine($"{firstDigit1}{secondDigit1} - {firstDigit2}{secondDigit2}");
                            validChangesCount++;

                            if (validChangesCount == 6)
                            {
                                return; // Exit the program after printing 6 valid changes
                            }
                        }
                        else if (areNumbersEqual)
                        {
                            Console.WriteLine("Cannot change the same player.");
                        }
                    }
                }
            }
        }
    }

    static bool IsNumberValid(int firstDigit, int secondDigit)
    {
        return firstDigit % 2 == 0 && secondDigit % 2 != 0;
    }
}