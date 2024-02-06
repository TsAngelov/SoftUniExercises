namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> occurances = new Dictionary<double, int>();

            foreach (var number in numbers) 
            {
                if (occurances.ContainsKey(number))
                {
                    occurances[number]++;
                }
                else
                {
                    occurances.Add(number, 1);
                }
            }

            foreach (var item in occurances)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
