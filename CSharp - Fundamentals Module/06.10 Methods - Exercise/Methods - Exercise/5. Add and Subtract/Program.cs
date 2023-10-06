namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            SubtractMethod(num1,num2, num3);
        }
        static int SumMethod(int num1, int num2) 
        {
            return num1 + num2;
        }
        static void SubtractMethod(int num1, int num2, int num3) 
        {
            Console.WriteLine(SumMethod(num1, num2) - num3); 
        }


    }
}