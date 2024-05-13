using BorderControl.Models;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Models.BorderControl bordercontrol = new();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] visitor = input.Split();

                if (visitor.Length == 2)
                {
                    Robot robot = new(visitor[1], visitor[0]);
                    bordercontrol.AddEntityCheck(robot);
                }
                else
                {
                    Citizen citizen = new(visitor[2], int.Parse(visitor[1]), visitor[0]);
                    bordercontrol.AddEntityCheck(citizen);
                }
            }

            string fakeId = Console.ReadLine();

            var detain = bordercontrol.Entities.Where(entity => entity.Id.EndsWith(fakeId));
            foreach (var detained in detain)
            {
                Console.WriteLine(detained.Id);
            }

        }
    }
}
