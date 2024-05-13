namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bas = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPow(bas,power));
        }
        static double MathPow (double bas, double power) 
        {
            return Math.Pow(bas, power);
        }
    }
}