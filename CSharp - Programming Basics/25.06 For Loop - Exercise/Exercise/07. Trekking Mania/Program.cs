using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double Musala = 0, Monblan = 0, Kili = 0, K2 = 0, Everest = 0, total = 0;
            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                total += people;
                if (people < 6) Musala += people;
                else if (people < 13) Monblan += people;
                else if (people < 26) Kili += people;
                else if (people <= 40) K2 += people;
                else if (people > 40) Everest += people;
            }
            Console.WriteLine($"{Musala / total * 100:f2}%");
            Console.WriteLine($"{Monblan / total * 100:f2}%");
            Console.WriteLine($"{Kili / total * 100:f2}%");
            Console.WriteLine($"{K2 / total * 100:f2}%");
            Console.WriteLine($"{Everest / total * 100:f2}%");
        }
    }
}
