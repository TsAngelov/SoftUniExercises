namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            string multiplyNumber = Console.ReadLine();

            Console.WriteLine(MultiplyNumbers(bigNumber, multiplyNumber));
        }

        private static string MultiplyNumbers(string bigNumber, string multiplyNumber)
        {
            if (bigNumber == "0" || multiplyNumber == "0")
            {
                return "0";
            }
            int carry = 0;
            int multiplier = int.Parse(multiplyNumber);

            char[] result = new char[bigNumber.Length + 1];

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNumber[i].ToString());
                int currentSum = digit * multiplier + carry;       

                result[i + 1] = (char)(currentSum % 10 + '0');
                carry = currentSum / 10;
            }

            if (carry > 0)
            {
                result[0] =  (char)(carry + '0');
            }

            return new string(result).TrimStart('\0');
        }
    }
}