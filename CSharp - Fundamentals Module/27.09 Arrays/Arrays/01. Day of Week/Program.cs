namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",    //0
                "Tuesday",   //1
                "Wednesday", //2
                "Thursday",  //3
                "Friday",    //4
                "Saturday",  //5
                "Sunday"     //6
            };
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 7)
                Console.WriteLine("Invalid day!");
            else
                Console.WriteLine(days[number - 1]);

        }
    }
}