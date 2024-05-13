namespace _02._Tax_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(">>").ToArray();
            double totalTax = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string[] currentVehicle = input[i].Split();
                string carType = currentVehicle[0];
                int taxYears = int.Parse(currentVehicle[1]);
                int kmTraveled = int.Parse(currentVehicle[2]);
                double tax = 0;
                switch (carType)
                {
                    case "family":
                        tax = 50;
                        tax = tax - taxYears * 5 + 12 * (kmTraveled / 3000);
                        break;
                    case "heavyDuty":
                        tax = 80;
                        tax = tax - taxYears * 8 + 14 * (kmTraveled / 9000);
                        break;
                    case "sports":
                        tax = 100;
                        tax = tax - taxYears * 9 + 18 * (kmTraveled / 2000);
                        break;
                    default:
                        Console.WriteLine("Invalid car type.");
                        continue;
                }
                totalTax += tax;
                Console.WriteLine($"A {carType} car will pay {tax:f2} euros in taxes.");
            }
            Console.WriteLine($"The National Revenue Agency will collect {totalTax:f2} euros in taxes.");
        }
    }
}