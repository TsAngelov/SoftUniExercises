namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] splitNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                    Console.WriteLine($"{splitNumbers[i]} => {(int)Math.Round(splitNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}