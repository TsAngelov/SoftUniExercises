namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input=Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(input));
            }
        }
        static bool IsPalindrome(string number)
        {
            int num = int.Parse(number);
            int numTemp = num;
            int reverse = 0;
            while (numTemp > 0) 
            {
                int reminder = numTemp % 10;
                reverse = reverse * 10 + reminder;
                numTemp /= 10;
            }
            if (reverse == num)
                return true;
            else
                return false;
        }
    }
}