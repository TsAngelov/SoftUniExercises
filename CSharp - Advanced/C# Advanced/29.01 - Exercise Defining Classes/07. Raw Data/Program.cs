using System.Linq;

namespace RawData;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string model = input[0];

            int engineSpeed = int.Parse(input[1]),
                enginePower = int.Parse(input[2]);
            Engine currentEngine = new Engine(engineSpeed, enginePower);

            int cargoWeight = int.Parse(input[3]);
            string cargoType = input[4];
            Cargo currentCargo = new Cargo(cargoType, cargoWeight);

            double tire1Pressure = double.Parse(input[5]),
                   tire2Pressure = double.Parse(input[7]),
                   tire3Pressure = double.Parse(input[9]),
                   tire4Pressure = double.Parse(input[11]);

            int tire1Age = int.Parse(input[6]),
                tire2Age = int.Parse(input[8]),
                tire3Age = int.Parse(input[10]),
                tire4Age = int.Parse(input[12]);
            Tires[] currentTires = new Tires[]
            {
                new Tires(tire1Age, tire1Pressure),
                new Tires(tire2Age, tire2Pressure),
                new Tires(tire3Age, tire3Pressure),
                new Tires(tire4Age, tire4Pressure)
            };

            cars.Add(new Car(model, currentEngine, currentCargo, currentTires));
        }

        string cargo = Console.ReadLine();
        if (cargo == "fragile")
        {
            cars = cars.Where(car => car.Cargo.Type == cargo)
                       .Where(car => car.Tires.Any(tire => tire.Pressure < 1))
                       .ToList();
        }
        else
        {
            cars = cars.Where(car => car.Cargo.Type == cargo)
                       .Where(car => car.Engine.Power > 250)
                       .ToList();
        }

        foreach (var item in cars)
        {
            Console.WriteLine(item.Model);
        }
    }
}
