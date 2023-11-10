namespace _05._Multiply_BigNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine((firstNum*secondNum).ToString("F0"));
        }
    }
}