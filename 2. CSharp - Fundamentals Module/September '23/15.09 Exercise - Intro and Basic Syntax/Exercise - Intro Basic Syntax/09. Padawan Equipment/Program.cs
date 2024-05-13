namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsaberCost = (lightsaberPrice * students) + (Math.Ceiling(students * 0.1) * lightsaberPrice);
            
            double robeCost = robePrice * students;
            double beltCost = 0;
            if (students >= 6)
            {
                beltCost = beltPrice * students;
                beltCost -= students / 6 * beltPrice;
            }
            else
                beltCost = beltPrice * students;
            double totalCost = lightsaberCost + robeCost + beltCost;
            if (totalCost <= money)
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            else
                Console.WriteLine($"John will need {totalCost-money:f2}lv more.");
        }
    }
}