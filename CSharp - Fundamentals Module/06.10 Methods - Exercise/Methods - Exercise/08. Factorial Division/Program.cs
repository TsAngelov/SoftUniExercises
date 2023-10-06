namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{factorial(n1)/factorial(n2):f2}");
        }
        static double factorial(double n) 
        {
            double factorial = n;
            for (double i = n - 1; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}