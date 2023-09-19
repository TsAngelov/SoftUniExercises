using System;

namespace _03._Stream_of_letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "", newWord = "";
            char letter = ' ';
            bool inputC = false, inputO = false, inputN = false;
            int count = 0;
            while (true)
            {
                if (count == 2)
                {
                    break;
                }
                if (inputC && inputN && inputO)
                {
                    newWord += output + " ";
                    output = "";
                    inputC = false; inputN = false; inputO = false;
                }

                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                letter = char.Parse(input);
                if (inputC == false)
                {
                    if (letter == 'c')
                    {
                        inputC = true;
                        continue;
                    }
                }
                if (inputO == false)
                {
                    if (letter == 'o')
                    {
                        inputO = true;
                        continue;
                    }
                }
                if (inputN == false)
                {
                    if (letter == 'n')
                    {
                        inputN = true;
                        continue;
                    }
                }
                if (char.IsLetter(letter))
                {
                    output += letter;
                }
            }
            Console.WriteLine(newWord);
        }
    }
}
