using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double student = 0, standard = 0, kids = 0, totalTickets = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish")
                {
                    Console.WriteLine($"Total tickets: {totalTickets}");
                    Console.WriteLine($"{student/totalTickets*100:f2}% student tickets.");
                    Console.WriteLine($"{standard/totalTickets*100:f2}% standard tickets.");
                    Console.WriteLine($"{kids/totalTickets*100:f2}% kids tickets.");
                    break;
                }
                double capacity = double.Parse(Console.ReadLine());
                int currenTicketsSold = 0;
                for (int i = 0; i < capacity; i++)
                {
                    string type = Console.ReadLine();
                    if (type == "End")
                    {
                        break;
                    }
                    switch (type)
                    {
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kids++;
                            break;
                    }
                    currenTicketsSold++;
                }
                if (currenTicketsSold == capacity)
                    Console.WriteLine($"{input} - {100:f2}% full.");
                else
                Console.WriteLine($"{input} - {currenTicketsSold / capacity * 100:f2}% full.");
                totalTickets += currenTicketsSold;
            }
        }
    }
}
