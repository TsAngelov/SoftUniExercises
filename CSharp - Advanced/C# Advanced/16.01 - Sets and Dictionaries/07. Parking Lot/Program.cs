namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split(", ");
                if (info[0] == "IN")
                {
                    parkingLot.Add(info[1]);
                }
                else
                {
                    parkingLot.Remove(info[1]);
                }
            }
            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(String.Join("\n", parkingLot));
            }

        }
    }
}
