using System.Diagnostics.CodeAnalysis;

namespace _01._Decrypting_Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                switch (command)
                {
                    case "Replace":
                        string currentChar = arguments[1];
                        string newChar = arguments[2];
                        text = text.Replace(currentChar, newChar);
                        Console.WriteLine(text);
                        break;

                    case "Cut":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        if (AreValidIndices(startIndex, endIndex, text))
                        {
                            text = text.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(text);
                        }
                        else
                            Console.WriteLine("Invalid indices!");
                        break;

                    case "Make":
                        string type = arguments[1];
                        if (type == "Upper")
                            text = text.ToUpper();
                        else
                            text = text.ToLower();
                        Console.WriteLine(text);
                        break;
                    case "Check":
                        string subString = arguments[1];
                        if (text.Contains(subString))
                            Console.WriteLine($"Message contains {subString}");
                        else
                            Console.WriteLine($"Message doesn't contain {subString}");
                        break;
                    case "Sum":
                        startIndex = int.Parse(arguments[1]);
                        endIndex = int.Parse(arguments[2]);
                        if (AreValidIndices(startIndex,endIndex,text))
                        {
                            char[] substring = text.Substring(startIndex, endIndex - startIndex + 1).ToArray();
                            int sum = 0;
                            foreach (char c in substring)
                            {
                                sum += c;
                            }
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                }
            }
        }
        static bool AreValidIndices(int startIndex, int endIndex, string text) 
        {
            if ((startIndex >= 0 && startIndex < text.Length) && (endIndex >= 0 && endIndex < text.Length))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
