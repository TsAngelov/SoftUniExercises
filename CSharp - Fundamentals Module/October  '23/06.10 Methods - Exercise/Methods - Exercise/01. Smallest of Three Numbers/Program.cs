namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            GetSmallestNum(num1, num2, num3);
        }
        static void GetSmallestNum (int num1, int num2, int num3)
        {
            int smallest = 0;
            if (Math.Max(num1,num2) == num1)
                smallest = num2;
            else
                smallest = num1;
            if (smallest > num3)
                smallest = num3;
            Console.WriteLine(smallest);
        }
    }
}