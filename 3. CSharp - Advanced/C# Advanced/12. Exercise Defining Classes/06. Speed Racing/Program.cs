namespace SpeedRacing;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Car> cars = new();

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            double fuelAmount = double.Parse(carInfo[1]);
            double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);
            Car newCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

            cars.Add(model, newCar);
        }
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] command = input.Split();
            string carModel = command[1];
            double amountOfKm = double.Parse(command[2]);

            cars[carModel].Drive(amountOfKm);
        }
        foreach (var car in cars)
        {
            Console.WriteLine(car.Value);
        }
    }
}
