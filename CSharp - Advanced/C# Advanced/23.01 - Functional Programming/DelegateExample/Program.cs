namespace DelegateExample
{
    internal class Program
    {
        public delegate int DoMath(int a, int b);
        static void Main(string[] args)
        {
            //  Single cast delegate
            // DoMath doMath = Add;
            // Console.WriteLine(doMath(5, 6));

            //  Multicast delegate
            DoMath doMath = Add;
            doMath += Multiply;
            doMath += Calculate;

            doMath(5, 7); // all 3 methods in 1
        }
        public static int Add(int a, int b)
        {
            Console.WriteLine(a+b);
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
            return a * b;
        }
        public static int Calculate(int a, int b)
        {
            Console.WriteLine(a * a + b * b);
            return a*a + b * b;
        }
    }
}
