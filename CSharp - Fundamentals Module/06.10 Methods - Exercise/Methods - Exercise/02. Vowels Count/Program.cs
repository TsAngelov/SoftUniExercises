using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetVowelNum(input);
        }
        static void GetVowelNum (string input) 
        {
            int vowelNum = 0;
            for (int i = 0; i < input.Length; i++) 
            {
                if ("AEIOUaeiou".Contains(input[i]))
                    vowelNum++;
            }
            Console.WriteLine(vowelNum);
        }
    }
}