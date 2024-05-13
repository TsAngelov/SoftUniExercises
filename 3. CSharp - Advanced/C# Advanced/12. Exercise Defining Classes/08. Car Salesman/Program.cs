namespace CarSalesman;

public class StartUp
{
    static void Main(string[] args)
    {
        Dictionary<string, Engine> engines = new();
        List<Car> cars = new();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = input[0];
            int power = int.Parse(input[1]);
            if (input.Length == 2)
            {
                Engine newEngine = new Engine(model, power);
                engines.Add(model, newEngine);
            }
            else if (input.Length == 3)
            {
                if (char.IsLetter(input[2][0]))
                {
                    string efficiency = input[2];
                    Engine newEngine = new Engine(model, power, efficiency);
                    engines.Add(model, newEngine);
                }
                else
                {
                    int displacement = int.Parse(input[2]);
                    Engine newEngine = new Engine(model, power, displacement);
                    engines.Add(model, newEngine);
                }
            }
            else
            {
                int displacement = int.Parse(input[2]);
                string efficiency = input[3];
                Engine newEngine = new Engine(model, power, displacement, efficiency);
                engines.Add(model, newEngine);
            }
        }

        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string carModel = carInput[0];
            Engine carEngine = engines[carInput[1]];

            if (carInput.Length == 2)
            {
                cars.Add(new Car(carModel, carEngine));
            }
            else if (carInput.Length == 3)
            {
                if (char.IsLetter(carInput[2][0]))
                {
                    string color = carInput[2];
                    cars.Add(new Car(carModel, carEngine, color));
                }
                else
                {
                    int weight = int.Parse(carInput[2]);
                    cars.Add(new Car(carModel, carEngine, weight));
                }
            }
            else
            {
                int weight = int.Parse(carInput[2]);
                string color = carInput[3];
                cars.Add(new Car(carModel, carEngine, weight, color));
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
