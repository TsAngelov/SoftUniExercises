namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<LivingBeing> livingBeings = new List<LivingBeing>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                if (tokens[0] == "Citizen")
                {
                    Citizen citizen = new(tokens[1], tokens[4], int.Parse(tokens[2]), tokens[3]);
                    livingBeings.Add(citizen);
                }
                else if (tokens[0] == "Pet")
                {
                    Pet pet = new Pet(tokens[1], tokens[2]);
                    livingBeings.Add(pet);
                }
            }

            string age = Console.ReadLine();
            foreach (var being in livingBeings)
            {
                if (being.Birthday.EndsWith(age))
                {
                    Console.WriteLine(being.Birthday);
                }
            }
        }
    }
}