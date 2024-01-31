namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        List<Tire[]> tires = new();
        List<Engine> engines = new();
        List<Car> cars = new();

        string input;
        while ((input = Console.ReadLine()) != "No more tires")
        {
            string[] tireInput = input.Split();
            int firstTireYear = int.Parse(tireInput[0]),
                secondTireYear = int.Parse(tireInput[2]),
                thirdTireYear = int.Parse(tireInput[4]),
                fourthTireYear = int.Parse(tireInput[6]);
            double firstTirePressure = double.Parse(tireInput[1]),
                   secondTirePressure = double.Parse(tireInput[3]),
                   thirdTirePressure = double.Parse(tireInput[5]),
                   fourthTirePressure = double.Parse(tireInput[7]);

            tires.Add(new Tire[]
            {
                new Tire(firstTireYear, firstTirePressure),
                new Tire(secondTireYear, secondTirePressure),
                new Tire(thirdTireYear, thirdTirePressure),
                new Tire(fourthTireYear, fourthTirePressure)
            });
        }

        while ((input = Console.ReadLine()) != "Engines done")
        {
            string[] engineInput = input.Split();
            engines.Add(new Engine(int.Parse(engineInput[0]), double.Parse(engineInput[1])));
        }

        while ((input = Console.ReadLine()) != "Show special")
        {
            string[] carInput = input.Split();
            string make = carInput[0];
            string model = carInput[1];
            int year = int.Parse(carInput[2]);
            double fuelQuantity = double.Parse(carInput[3]);
            double fuelConsumption = double.Parse(carInput[4]);
            int engineIndex = int.Parse(carInput[5]);
            int tiresIndex = int.Parse(carInput[6]);

            Car currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);

            if (currentCar.Year >= 2017 && currentCar.Engine.HorsePower > 330)
            {
                double pressureSum = 0;
                foreach (var pressure in currentCar.Tires)
                {
                    pressureSum += pressure.Pressure;
                }
                if (pressureSum > 9 && pressureSum < 10)
                {
                    currentCar.FuelQuantity -= currentCar.FuelConsumption / 100 * 20;
                }
            }
            cars.Add(currentCar);
        }
        foreach (var car in cars)
        {
            if (car.Year >= 2017 && car.Engine.HorsePower > 330)
            {
                double pressureSum = 0;
                foreach (var pressure in car.Tires)
                {
                    pressureSum += pressure.Pressure;
                }
                if (pressureSum > 9 && pressureSum < 10)
                {
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}
