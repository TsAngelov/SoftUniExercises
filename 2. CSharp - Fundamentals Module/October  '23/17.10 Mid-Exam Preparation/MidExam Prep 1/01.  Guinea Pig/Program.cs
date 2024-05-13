namespace _01.__Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kgFood = double.Parse(Console.ReadLine()) * 1000;
            double kgHay = double.Parse(Console.ReadLine()) * 1000;
            double kgCover = double.Parse(Console.ReadLine()) * 1000;
            double kgGuinea = double.Parse(Console.ReadLine()) * 1000;
            for (int i = 1; i <= 30; i++)
            {
                kgFood -= 300;
                if (i%2 == 0)
                    kgHay -= kgFood * 0.05;
                if (i%3==0)
                    kgCover -= kgGuinea / 3;
                if (kgFood <= 0 || kgHay <= 0 || kgCover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {kgFood/1000:f2}, Hay: {kgHay/1000:f2}, Cover: {kgCover / 1000:f2}.");
        }
    }
}