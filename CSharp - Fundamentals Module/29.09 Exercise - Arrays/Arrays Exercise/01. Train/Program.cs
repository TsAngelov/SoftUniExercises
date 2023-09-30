namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] people = new int[wagons];
            for (int i = 0; i < wagons; i++)
            {
                people[i] += int.Parse(Console.ReadLine());
                sum += people[i];
            }
            foreach (int peopleWagon in people)
            {
                Console.Write(peopleWagon + " ");
            }
            Console.WriteLine();
            Console.Write(sum);
        }
    }
}